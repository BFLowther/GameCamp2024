using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCPickup : MonoBehaviour
{
    public GameManager gm;

    private void Start()
    {
        gm = GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "NPC")
            {
                Destroy(col.gameObject);
                gm.NPCCounterAdd();
            }
        }
    }
}