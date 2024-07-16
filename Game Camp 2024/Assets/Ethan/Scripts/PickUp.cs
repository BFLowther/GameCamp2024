using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum interractables
{
    haystack,
    npc,
    key,
    plank,
    door
}
public class PickUp : MonoBehaviour
{
    public interractables things = new interractables();
    public GameObject NPCPrefab;
    public GameObject NPCLocation;
    void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            switch (this.things)
            {
                case interractables.npc:
                    //Debug.Log("Collided with NPC");
                    GameObject.Find("NPCManager").GetComponent<NPCCounter>().NPCSaved();
                    GameObject.Destroy(gameObject);
                    break;
                case interractables.haystack:
                    //Debug.Log("Collided with haystack");
                    GameObject.Find("NPCManager").GetComponent<NPCCounter>().HaystackSaved();
                    GameObject.Destroy(gameObject);
                    break;
                case interractables.key:
                    //Debug.Log("Collided with key");
                    GameObject.Find("NPCManager").GetComponent<NPCCounter>().KeySaved();
                    GameObject.Destroy(gameObject);
                    break;
                case interractables.plank:
                    //Debug.Log("Collided with plank");
                    GameObject.Find("NPCManager").GetComponent<NPCCounter>().PlankSaved();
                    GameObject.Destroy(gameObject);
                    break;
                case interractables.door:
                    //Debug.Log("Collided with door");
                    if(GameObject.Find("NPCManager").GetComponent<NPCCounter>().KeyCount >= 1)
                    {
                        GameObject.Find("NPCManager").GetComponent<NPCCounter>().KeyCount = GameObject.Find("NPCManager").GetComponent<NPCCounter>().KeyCount-1;
                        GameObject.Destroy(gameObject);
                        GameObject.Instantiate(NPCPrefab, NPCLocation.transform);
                    }
                    break;
            };
        }
    }
}
