using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

public float moveSpeed = 5f; //controls how fast player moves

public Rigidbody2D rb;
Vector2 movement;

public Animator animator; //references the animation/animator in unity so when player moves,animation plays


    // Start is called before the first frame update


    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); //makes sure that the player goes the same speed for all directions
    }
}
