using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGate : MonoBehaviour
{
    public GameTimer gt;
    public GameObject leaderboard;
    public GameObject UI;
    public int totalNPCs = 10;
    public NPCCounter nc;
    public Leaderboard lb;
    public GameObject player;
    public Sprite[] expressions;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            if (nc.currentScore == totalNPCs)
                player.GetComponent<Image>().sprite = expressions[0];
            else if (nc.currentScore >= totalNPCs-3)
                player.GetComponent<Image>().sprite = expressions[1];
            else if (nc.currentScore >= totalNPCs - 6)
                player.GetComponent<Image>().sprite = expressions[2];
            else
                player.GetComponent<Image>().sprite = expressions[3];
            nc.currentScore *= (int) gt.currentTime;
            leaderboard.SetActive(true);
            UI.SetActive(false);
            lb.AddHighScoreEntry((int)nc.currentScore, "JON");
            Debug.Log("game ended");
        }
    }
}
