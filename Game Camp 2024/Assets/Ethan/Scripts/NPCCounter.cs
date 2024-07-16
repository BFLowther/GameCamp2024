using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NPCCounter : MonoBehaviour
{
    public static NPCCounter instance;
    int NPCCount = 0;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void NPCSaved()
    {
        NPCCount++;
        Debug.Log(NPCCount);
    }
}
