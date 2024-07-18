using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    SpriteRenderer player;
    public Rigidbody2D controller;
    public NPCCounter counter;
    public float walkSpeed = 25f;
  
    Vector2 movement;
    private void Awake()
    {
        player = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update() {
        movement.x = Input.GetAxisRaw("Horizontal");
        
        walkSpeed = counter.speed;
        Debug.Log("Current Speed: " + walkSpeed);
          
    }
       
    void FixedUpdate ()
    {
        //Move our Character
        //Min
        if(walkSpeed <= 1f)
        {
            walkSpeed = 1f;
            
        }
        if (movement.x != 0)
        {
            player.flipX = (movement.x>0);
            controller.MovePosition(controller.position + movement * walkSpeed * Time.fixedDeltaTime);
        }
    }

}
