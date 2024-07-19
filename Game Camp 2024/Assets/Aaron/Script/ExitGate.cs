using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGate : MonoBehaviour
{
    public GameTimer gt;
    public NPCCounter nc;
    public Leaderboard lb;
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            nc.currentScore *= (int) gt.currentTime;
            lb.AddHighScoreEntry((int)nc.currentScore, "JON");
            Debug.Log("game ended");
        }
    }
}
