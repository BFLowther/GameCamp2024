using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum interractables
{
    haystack,
    npc,
    key
}
public class PickUp : MonoBehaviour
{
    public interractables things = new interractables();

    void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            switch (this.things)
            {
                case interractables.npc:
                    Debug.Log("Collided with NPC");
                    GameObject.Find("NPCManager").GetComponent<NPCCounter>().NPCSaved();
                    break;
                case interractables.haystack:
                    Debug.Log("Collided with haystack");
                    break;
                case interractables.key:
                    Debug.Log("Collided with key");
                    break;
            };
            GameObject.Destroy(gameObject);
        }
    }
}
