using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LastUi : MonoBehaviour
{
    public int totalNPCs = 25;
    public Leaderboard lb;
    public GameObject player;
    public Sprite[] expressions;

    private void Awake()
    {
        player = transform.Find("Image").gameObject;
    }
    public void Retry()
    {
      SceneManager.LoadScene("WhiteBox");
    }
    public void GiveUp()
    {
      SceneManager.LoadScene("MainMenu");
    }
    private void Start()
    {
        int savedNPC = PlayerPrefs.GetInt("NPCSaved", 0);

        if (expressions.Length < 4)
        {
            Debug.LogError("The expressions array does not have enough elements.");
            return;
        }

        if (savedNPC == totalNPCs)
            player.GetComponent<Image>().sprite = expressions[0];
        else if (savedNPC >= totalNPCs - 5)
            player.GetComponent<Image>().sprite = expressions[1];
        else if (savedNPC >= totalNPCs - 10)
            player.GetComponent<Image>().sprite = expressions[2];
        else
            player.GetComponent<Image>().sprite = expressions[3];
    }
}
