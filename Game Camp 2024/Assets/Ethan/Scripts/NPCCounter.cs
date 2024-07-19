using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class NPCCounter : MonoBehaviour
{
    public static NPCCounter instance;
    public int NPCCount = 0;
    public float speed = 25f;
    public int KeyCount = 0;
    public int PlankCount = 0;
    public int NeedleCount = 0;
    public TextMeshProUGUI NPCText;
    public float currentScore = 0f;
    public TMP_Text finalText;
    public TMP_Text highText;
    public float npcScore = 20f;

    // Start is called before the first frame update
    void Awake()
    {
        NPCText.text = "NPCS:";
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void NPCSaved()
    {
        NPCCount++;
        speed--;
        ChangeScore(npcScore);
        NPCText.text = (" NPCs: " + NPCCount);

    }

    public void HaystackSaved()
    {
            NeedleCount++;
        
    }

    public void KeySaved()
    {
        KeyCount++;
        Debug.Log(KeyCount + " Keys collected");
    }

    public void PlankSaved()
    {
        PlankCount++;
        Debug.Log(PlankCount + " Planks collected");
    }

    public void ChangeScore(float points)
    {
        currentScore += points;
    }

    public void HighScoreUpdate()
    {
        if (PlayerPrefs.HasKey("SavedHighScore"))
        {
            if(currentScore > PlayerPrefs.GetFloat("SavedHighScore"))
            {
                PlayerPrefs.SetFloat("SavedHighScore", currentScore);
            }
        }
        else
        {
            PlayerPrefs.SetFloat("SavedHighScore", currentScore);
        }

        finalText.text = currentScore.ToString();
        highText.text = PlayerPrefs.GetFloat("SavedHighScore").ToString();
    }
}
