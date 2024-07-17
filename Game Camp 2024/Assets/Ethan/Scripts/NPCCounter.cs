using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class NPCCounter : MonoBehaviour
{
    public static NPCCounter instance;
    public int NPCCount = 0;
    public float speed = 25f;
    public int HaystackCount = 0;
    public int KeyCount = 0;
    public int PlankCount = 0;
    public int NeedleCount = 0;
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
        speed--;
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
