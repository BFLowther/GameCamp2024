using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public TMP_Text timeUI;  
    public float currentTime = 10f;
    public UnityEvent outOfTime;

    private bool m_running = true;

    public void StopClock()
    {
        m_running = false;
    }

    void Start()
    {
        if (timeUI == null)
        {
            Debug.LogError("GameObject: " + gameObject.name + " has no connection to timeUI!");
        }
    }
   
    // Update is called once per frame
    void Update()
    {
        if (m_running == false)
            return;
        
       if (currentTime<=0.0f)
       {
            currentTime = 0.0f;   
            return;
       }

        currentTime -= Time.deltaTime;

        if(currentTime<=0.0f)
        {
            Debug.Log("You Died");
            outOfTime.Invoke();
        }

        if (timeUI)
        {
            int min=0;
            int sec=0;

            if(currentTime>=60f)
                min=(int)currentTime/60;
            else
                min=0;

            sec=(int)Mathf.Ceil(((currentTime/60f)-min)*60f);

            if (sec == 60)
            {
                min++;
                sec = 0;
            }

            if(sec<=9)
                timeUI.text = min + ":0" + sec;
            else
                timeUI.text = min + ":" + sec;
        }
    }
}
