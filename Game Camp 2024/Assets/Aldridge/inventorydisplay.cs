using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class inventorydisplay : MonoBehaviour
{
    public NPCCounter npcCounter;
    public TMP_Text needleDisplay;
    public TMP_Text keyDisplay;
    public TMP_Text plankDisplay;

    // Update is called once per frame
    void Update()
    {
        keyDisplay.text = npcCounter.KeyCount.ToString();
        plankDisplay.text = npcCounter.PlankCount.ToString();
        needleDisplay.text = npcCounter.NeedleCount.ToString();
    }

}
