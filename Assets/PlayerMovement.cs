using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5.0f;      // Movement speed
    public float jumpForce = 12.0f;         // Jump height

    private Rigidbody2D playerRigidBody;    // RigidBody component

    private bool isGrounded;                // Flag to see if we touch the ground
    public Transform groundChecker;         // GameObject to check if grounded
    public float groundCheckRadius = 0.2f;  // Radius for ground check
    public LayerMask terrainLayer;          // Layer for objects we can step on and jump

    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get horizontal input
        float moveX = Input.GetAxis("Horizontal");

        // Move the player
        playerRigidBody.velocity = new Vector2(moveX * movementSpeed, playerRigidBody.velocity.y);

        // Check if the player stand on 
        isGrounded = Physics2D.OverlapCircle(groundChecker.position, groundCheckRadius, terrainLayer);

        // Jump if the player is grounded and presses Jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, jumpForce);
        }
    }
}
