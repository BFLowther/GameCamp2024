using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D controller;

    public float walkSpeed = 25f;
  
    Vector2 movement;

    // Update is called once per frame
    void Update() {
        movement.x = Input.GetAxisRaw("Horizontal");
    
    }

    void FixedUpdate ()
    {
        //Move our Character
        controller.MovePosition( controller.position + movement * walkSpeed * Time.fixedDeltaTime );
    }

}
