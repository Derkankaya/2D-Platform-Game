using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class CharSC : MonoBehaviour
{
    Rigidbody2D rgb ;
    Animator animator;

    Vector3 velocity;

   public float runAmount = 15f;
  public  float walkAmount = 5f;
   public float jumpAmount = 9f;

    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        MovedCharacter();

    }

    public void MovedCharacter()
    {
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        float currentSpeed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
             currentSpeed = runAmount;
            animator.SetBool("isRun", true);
            animator.SetBool("isWalk", false);
           
           // animator.SetBool("isJump", false);
        }
        else if (Mathf.Approximately(velocity.x, 0f))
        {
            currentSpeed = 0f;
            animator.SetBool("isRun", false);
            animator.SetBool("isWalk", false);
           // animator.SetBool("isJump", false);
        }
        else
        {
            currentSpeed = walkAmount;
            animator.SetBool("isRun", false);
            animator.SetBool("isWalk", true);
           // animator.SetBool("isJump", false);
        }

        transform.position += velocity * currentSpeed * Time.deltaTime;

        if (Input.GetButtonDown("Jump") && Mathf.Approximately(rgb.velocity.y, 0))
        {
            rgb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            animator.SetBool("isJump", true);
           // animator.SetBool("isRun", false);
          //  animator.SetBool("isWalk", false);
        }
 
        if (Mathf.Approximately(rgb.velocity.y, 0))
        {
            animator.SetBool("isJump", false);
         //   animator.SetBool("isRun", false);
         //   animator.SetBool("isWalk", false);
        }

        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }
    
}
