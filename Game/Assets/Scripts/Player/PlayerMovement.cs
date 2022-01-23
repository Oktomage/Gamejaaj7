using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public Animator mainAnimator;
    public Rigidbody2D rb;
    float input_x = 0;
    float input_y = 0;
    public float speed;
    private bool isWalking;
    private bool movingRight;
    // Start is called before the first frame update
    void Start()
    {
        isWalking = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();

    }
    
    void Move(){
        input_x = Input.GetAxisRaw("Horizontal");
        input_y = Input.GetAxisRaw("Vertical");
        isWalking = (input_x != 0 || input_y != 0);

        if(isWalking){
            var move = new Vector2(input_x, input_y) * speed;
            rb.velocity = move;

        }else{
            rb.velocity = new Vector2(0,0);
        }
        if(input_x < 0 && !movingRight){
			Flip();
		}else if(input_x > 0 && movingRight){
			Flip();
		}

    }

    void Flip(){
        //Moving right serve para manter o movimento constante, sem ele o personagem fica virando furiosamente
        movingRight = !movingRight;
        transform.localScale = new Vector3((transform.localScale.x * -1), transform.localScale.y, transform.localScale.z);
    }
}
