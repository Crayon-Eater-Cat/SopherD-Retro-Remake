using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float move;
    bool grounded;

    private Vector2 CheckyPointy;
    
    public KeyCode left, right;
    public float maxSpeed;
    public float buildUp;

    public KeyCode jump;
    public float jumpForce;

    private Rigidbody2D moveit;
    //SpriteRenderer SprRNDr;
    void Start()
    {
        moveit = GetComponent<Rigidbody2D>();
        //SprRNDr = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (Input.GetKey(left))
        {
            moveit.AddForce(Vector2.left * buildUp);
        }
        if (Input.GetKey(right))
        {
            moveit.AddForce(Vector2.right * buildUp);
        }

        if (Input.GetKeyDown(jump) && grounded == true)
        {
            moveit.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        moveit.velocity=new Vector2(Mathf.Clamp(moveit.velocity.x, -maxSpeed, maxSpeed), moveit.velocity.y);
    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
        //else
        //{
        //    grounded = false;
        //}
    }

    private void OnCollisionExit2D(Collision2D other)
    {
         if (other.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("CheckPoint"))
        {
            CheckyPointy = other.transform.position;
        }
    }
}