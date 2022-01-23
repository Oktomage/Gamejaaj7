using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Main")]
    public PlayerBody Body;

    [Header("Vars")]
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
        //Walk
        if(Body.CanWalk)
        {
            rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed;
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }

        #region Tests

        //Is walking ?
        if (rb.velocity.x != 0 || rb.velocity.y != 0)
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

        #endregion
    }

    private void Flip(){
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
