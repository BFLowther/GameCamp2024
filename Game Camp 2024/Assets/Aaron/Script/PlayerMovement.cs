using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D controller;
    public NPCCounter counter;
    public float walkSpeed = 25f;
  
    Vector2 movement;

    // Update is called once per frame
    void Update() {
        movement.x = Input.GetAxisRaw("Horizontal");
        
        //walkSpeed = counter.speed;
        Debug.Log("Current Speed: " + walkSpeed);
        //Min
        if(walkSpeed <= 1f)
        {
            walkSpeed = 1f;
            
        }    
    }
       
    void FixedUpdate ()
    {
        //Move our Character
        controller.MovePosition( controller.position + movement * walkSpeed * Time.fixedDeltaTime );
    }

}
