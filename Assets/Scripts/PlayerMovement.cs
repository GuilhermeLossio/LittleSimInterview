using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("PlayerMovement")]
    //Here we can create the basic things for the movement
    public float speed;
    public Rigidbody2D rigidPlayer;
    public Vector2 movement = Vector2.zero;

    //Here we get the player sprit Renderer to make the flip action.

    
    private SpriteRenderer playerImage;

    void Start() {
        //Here we get the RigdbodyFromPlayer
        rigidPlayer = GetComponent<Rigidbody2D>();

        playerImage = GetComponent<SpriteRenderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }



    //Make the movement
    private void FixedUpdate() {
        rigidPlayer.MovePosition(rigidPlayer.position + movement * speed * Time.deltaTime);

        

        //Here we make the player able to move the direction
        // The player still a place holder
        if(movement.x > 0)
        {
            transform.localScale = new Vector3(1,1,1);

            //playerImage.flipX = false;
        }
        else if(movement.x < 0)
        {
            transform.localScale = new Vector3(-1,1,1);
            //playerImage.flipX = true;
        }
    }
}
