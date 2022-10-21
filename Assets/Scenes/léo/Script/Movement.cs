using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float horizontal;
    private bool isFacingRight = true;

    public float speed = 8f;
    public float jumpingPower = 16f;
    private bool grounded;
    public Transform groundcheck;
    public float GroundCheckRadius;
    public LayerMask monLayer;
 

    public bool isMoving;


    [SerializeField] private Rigidbody2D rb;


    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump")&& grounded)
        {

                rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            grounded = false;
        }
        /* if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
         {
             rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
         }*/
        // grounded = Physics2D.OverlapCircle(groundcheck.position, GroundCheckRadius, monLayer);
        
        if(horizontal<0 || horizontal > 0)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
        
        Debug.Log(isMoving);
        Flip();

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }


    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }


    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(groundcheck.position, GroundCheckRadius);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("floor"))
        {
            grounded = true;
        }
        
    }
}
