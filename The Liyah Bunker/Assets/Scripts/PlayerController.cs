using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

public float moveSpeed = 5f; //controls how fast player moves

public Rigidbody2D rb;
    private RockThrower thrower;
Vector2 movement;

public Animator animator; //references the animation/animator in unity so when player moves,animation plays

   private bool IsRunning;
    private bool walking;

    // Start is called before the first frame update
    void Start(){
    walking = false;
        thrower = GetComponent<RockThrower>();
    }
    
    
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
         //Idle Facing Directions
            if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
            {
                animator.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
                animator.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
            }
            
             if (movement.magnitude > 0.3f)
        {
            
            walking = true;
        }
        else
        {
            if (walking == true)
            {
                walking = false;
                
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
