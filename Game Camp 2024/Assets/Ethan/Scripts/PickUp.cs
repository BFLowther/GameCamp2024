using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

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
    public HouseBehavoir house;
    //public GameObject pickUpText;
    public bool isInsideTrigger;
    public NPCCounter counter;
    public Transform player;
    float minDistance = 1.5f;
    public float npcScore = 20f;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        //pickUpText.SetActive(isInsideTrigger);
        if (Input.GetKey(KeyCode.E) == true)
        {
            if(Mathf.Abs(player.position.x - transform.position.x) < minDistance)
            {
                SwitchCases();
            }
        }
    }
    void SwitchCases()
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
                            house.ChangeDoor();
                            int NumSpawn = Random.Range(1, 4);
                            for(float q = 0f; q<NumSpawn; q++)
                            {
                                GameObject GO = GameObject.Instantiate(NPCPrefab, NPCLocation.transform);
                                GO.transform.parent = null;
                                Vector2 pos = GO.transform.position;
                                pos.x += q+(.5f*q);
                                GO.transform.position = pos;
                            }
                            GameObject.Destroy(gameObject);
                        }
                        break;
                }
     }
}
