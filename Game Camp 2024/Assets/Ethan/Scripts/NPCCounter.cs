using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class NPCCounter : MonoBehaviour
{
    public static NPCCounter instance;
    int NPCCount = 0;
    int HaystackCount = 0;
    int KeyCount = 0;
    int PlankCount = 0;
    int NeedleCount = 0;
    public TextMeshProUGUI NPCText;

    // Start is called before the first frame update
    void Awake()
    {
        NPCText.text = "NPCS:";
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
        NPCText.text = (" NPCs: " + NPCCount);

    }

    public void HaystackSaved()
    {
        HaystackCount++;
        Debug.Log(HaystackCount + " Haystacks collected");
        
    }

    public void KeySaved()
    {
        KeyCount++;
        Debug.Log(KeyCount + " Keys collected");
    }

    public void PlankSaved()
    {
        PlankCount++;
        Debug.Log(PlankCount + " Planks collected");
    }

}
