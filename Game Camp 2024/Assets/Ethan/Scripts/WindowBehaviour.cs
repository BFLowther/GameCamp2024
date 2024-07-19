using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowBehavior : MonoBehaviour
{
    public Sprite open;
    SpriteRenderer window;
    // Start is called before the first frame update
    void Start()
    {
        window = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    public void ChangeDoor()
    {
        window.sprite = open;
    }
}
