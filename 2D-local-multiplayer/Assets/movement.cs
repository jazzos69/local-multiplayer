using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float plMaxSpeed = 5f;
    public float jumpForce = 10f;
    public float moveForce = 10f;
    private Rigidbody2D rb;
    public KeyCode left;
    public KeyCode right;
    public KeyCode up;
    public KeyCode down;
    public bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = 0f;

        if (Input.GetKey(left))
        {
            horizontalInput = -1f;
        }
        else if (Input.GetKey(right))
        {
            horizontalInput = 1f;
        }

        rb.velocity = new Vector2(horizontalInput * plMaxSpeed, rb.velocity.y);

        if (Mathf.Abs(rb.velocity.x) < plMaxSpeed)
        {
            rb.AddForce(new Vector2(horizontalInput * moveForce, 0f), ForceMode2D.Force);
        }

        if (Input.GetKeyDown(up) && isGrounded)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}

