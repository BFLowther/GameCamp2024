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
    public int KeyCount = 0;
    public int PlankCount = 0;
    public int NeedleCount = 0;
    public TextMeshProUGUI NPCText;
    public float currentScore = 0f;
    public float npcScore = 20f;
    public AudioSource npc;
    public AudioSource needle;
    public AudioSource plank;
    public AudioSource key;

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
        if (Input.GetKeyDown(KeyCode.Q))
        {
            NPCUnSaved();
        }
    }


    public void NPCSaved()
    {
        NPCCount++;
        speed--;
        ChangeScore(npcScore);
        npc.Play();
        NPCText.text = (" NPCs: " + NPCCount);

    }

    public void NPCUnSaved()
    {
        if (NPCCount != 0)
        {
            NPCCount--;
            speed++;
            ChangeScore(-1 * npcScore);
            NPCText.text = (" NPCs: " + NPCCount);
        }
    }

    public void HaystackSaved()
    {
        NeedleCount++;
        needle.Play();
    }

    public void KeySaved()
    {
        KeyCount++;
        key.Play();
        //Debug.Log(KeyCount + " Keys collected");
    }

    public void PlankSaved()
    {
        PlankCount++;
        plank.Play();
        //Debug.Log(PlankCount + " Planks collected");
    }

    public void ChangeScore(float points)
    {
        currentScore += points;
    }

    public void HighScoreUpdate()
    {
        if (PlayerPrefs.HasKey("SavedHighScore"))
        {
            if(currentScore > PlayerPrefs.GetFloat("SavedHighScore"))
            {
                PlayerPrefs.SetFloat("SavedHighScore", currentScore);
            }
        }
        else
        {
            PlayerPrefs.SetFloat("SavedHighScore", currentScore);
        }

    }
}
