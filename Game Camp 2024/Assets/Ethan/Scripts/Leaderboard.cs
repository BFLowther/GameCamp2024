using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Leaderboard : MonoBehaviour
{
    public Transform entryContainer;
    public Transform entryTemplate;
    List<Transform> highScoreEntryTransformList;

    void Awake()
    {
        entryTemplate.gameObject.SetActive(false);
        string jsonString = PlayerPrefs.GetString("highScoreTable");
        HighScores highscores = string.IsNullOrEmpty(jsonString) ? new HighScores() : JsonUtility.FromJson<HighScores>(jsonString);

        for (int i = 0; i < highscores.highScoreEntryList.Count; i++)
        {
            for (int j = i + 1; j < highscores.highScoreEntryList.Count; j++)
            {
                if (highscores.highScoreEntryList[j].score > highscores.highScoreEntryList[i].score)
                {
                    HighScoreEntry temp = highscores.highScoreEntryList[i];
                    highscores.highScoreEntryList[i] = highscores.highScoreEntryList[j];
                    highscores.highScoreEntryList[j] = temp;
                }
            }
        }

        highScoreEntryTransformList = new List<Transform>();
        foreach (HighScoreEntry highScoreEntry in highscores.highScoreEntryList)
        {
            CreateHighScoreEntryTransform(highScoreEntry, entryContainer, highScoreEntryTransformList);
        }
    }

    private void CreateHighScoreEntryTransform(HighScoreEntry highscoreEntry, Transform container, List<Transform> transformList)
    {
        float templateHeight = 20f;
        Transform entryTransform = Instantiate(entryTemplate, container);
        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
        entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count);
        entryTransform.gameObject.SetActive(true);

        int score = highscoreEntry.score;
        entryTransform.Find("scoreText").GetComponent<TextMeshProUGUI>().text = score.ToString();

        string name = highscoreEntry.name;
        entryTransform.Find("nameText").GetComponent<TextMeshProUGUI>().text = name;

        transformList.Add(entryTransform);
    }

    public void AddHighScoreEntry(int score, string name)
    {
        HighScoreEntry highScoreEntry = new HighScoreEntry { score = score, name = name };

        string jsonString = PlayerPrefs.GetString("highScoreTable");
        HighScores highscores = string.IsNullOrEmpty(jsonString) ? new HighScores() : JsonUtility.FromJson<HighScores>(jsonString);

        highscores.highScoreEntryList.Add(highScoreEntry);

        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("highScoreTable", json);
        PlayerPrefs.Save();
    }

    public void ClearHighScores()
    {
        PlayerPrefs.DeleteKey("highScoreTable");
    }

    private class HighScores
    {
        public List<HighScoreEntry> highScoreEntryList = new List<HighScoreEntry>();
    }

    [System.Serializable]
    private class HighScoreEntry
    {
        public int score;
        public string name;
    }
}
