using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;          // Movement speed
    public float jumpForce = 10.0f;    // Jump height

    private Rigidbody2D rb;

    private bool isGrounded;
    public Transform groundCheck;    // Position to check if grounded
    public float groundCheckRadius = 0.2f; // Radius for ground check
    public LayerMask groundLayer;    // Layer for ground detection

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get horizontal input
        float moveX = Input.GetAxis("Horizontal");

        // Move the player
        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);

        // Check if the player is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        // Jump if the player is grounded and presses Jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
