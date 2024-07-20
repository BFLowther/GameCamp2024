using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseBehavoir : MonoBehaviour
{
    public Sprite open;
    public AudioSource door;
    SpriteRenderer house;
    // Start is called before the first frame update
    void Start()
    {
        house = GetComponent<SpriteRenderer>();
    }
    

    // Update is called once per frame
    public void ChangeDoor()
    {
        door.Play();
        house.sprite = open;
    }
}
