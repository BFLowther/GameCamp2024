using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRando : MonoBehaviour
{
    public Sprite[] Sprites;
    // Start is called before the first frame update
    void Start()
    {

        GetComponent<SpriteRenderer>().sprite = Sprites[Random.Range(0, Sprites.Length)];
    }

}
