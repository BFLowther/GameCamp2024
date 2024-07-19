using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGate : MonoBehaviour
{
    public GameTimer gt;
    public NPCCounter nc;
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            nc.currentScore *= (int)gt.currentTime;
            Debug.Log("game ended");
        }
    }
}
