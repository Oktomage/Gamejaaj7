using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Vars
    public float speed;

    //Conditions
    internal bool isWalking;
    internal bool movingRight;

    [Header("Components")]
    public Rigidbody2D rb;
    public SpriteRenderer spriteRend;

    void Start()
    {
        isWalking = false;
    }

    void FixedUpdate()
    {
        Move();
    }
    
    void Move(){
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed;

        //Is walking ?
        if(rb.velocity.x != 0 || rb.velocity.y != 0)
        {
            isWalking = true;

            //Flip
            if(rb.velocity.x != 0)
            {
                Flip();
            }
        }
        else
        {
            isWalking = false;
        }
    }

    void Flip(){
        if(rb.velocity.x > 0)
        {
            spriteRend.flipX = false;
        }
        else
        {
            spriteRend.flipX = true;
        }
    }
}
