using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGate : MonoBehaviour
{
    public GameTimer gt;
    public GameObject leaderboard;
    public GameObject UI;
    public NPCCounter nc;
    public Leaderboard lb;

    [System.Obsolete]
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            nc.currentScore *= (int) gt.currentTime;
            leaderboard.active = true;
            UI.active = false;
            lb.AddHighScoreEntry((int)nc.currentScore, "JON");
            Debug.Log("game ended");
        }
    }
}
