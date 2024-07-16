using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    
    public float currentTime =10f;
 
   
    // Update is called once per frame
    void Update()
    {
       if (currentTime<=0.0f)
       {
            currentTime = 0.0f;   
            return;
       }

        currentTime -=Time.deltaTime;

        if(currentTime<=0.0f)
        {
            Debug.Log("You Died");
        }
    }
}
