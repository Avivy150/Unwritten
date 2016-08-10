using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour
{ 
    
    public float jumpTime;
    public equitmentWindow eWindow;
    public float runSpeed = 4f;
    public bool isWalking = false;
    [HideInInspector]
    public float horizontalInput;
    [HideInInspector]
    public float verticalInput;

    bool canJump = true;
    public bool up;
    public bool right;
    public bool down;
    public bool left;
    public Vector3 position;

    Animator animator;
    Vector2 movement2D;
    SpriteRenderer spriteRenderer;
    Rigidbody2D rigidBody2D;
    Animation animations;

    [Tooltip("Distance the unit will jump.")]
    public float jumpHeight = 1f;
    bool isJumping = false;

    void Start()
    {
        rigidBody2D = gameObject.GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    { 
      
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        right = horizontalInput > 0;
        left = horizontalInput < 0;
        up = verticalInput > 0;
        down = verticalInput < 0;
        position = transform.position;

        isWalking = (Mathf.Abs(horizontalInput) + Mathf.Abs(verticalInput)) > 0;

        animator.SetBool("isWalking", isWalking);

        if (isWalking)
        {
            animator.SetFloat("X", horizontalInput);
            animator.SetFloat("Y", verticalInput);

            FlipSprite();

            ReduceAnimationSpeedIfMovingDiagonally();
        }

        if (Input.GetButtonDown("Jump") )
        {
            isJumping = true;
        }
    }

   

    void FixedUpdate()
    {
        if (isWalking || isJumping)
        {
            MoveUnit(horizontalInput, verticalInput);
        } 
        if (isJumping && canJump)
        {
            canJump = false;
            Jump(); 
        }
    }

    void Jump()
    {
        print("jump!");
        isJumping = false; 
        wait(jumpTime);
        canJump = true;
    }

    IEnumerator wait(float time)
    {
        yield return new WaitForSeconds(time);
    }
    void ReduceAnimationSpeedIfMovingDiagonally()
    {
        if (horizontalInput == -1 && verticalInput == -1)
        {
            animator.speed = 0.65f;
        }
        else if (horizontalInput == 1 && verticalInput == 1)
        {
            animator.speed = 0.65f;
        }
        else if (horizontalInput == 1 && verticalInput == -1)
        {
            animator.speed = 0.65f;
        }
        else if (horizontalInput == -1 && verticalInput == 1)
        {
            animator.speed = 0.65f;
        }
        else if (horizontalInput == 0 && verticalInput == 1)
        {
            animator.speed = 0.5f;
        }
        else if (horizontalInput == 0 && verticalInput == -1)
        {
            animator.speed = 0.5f;
        }
        else
        {
            animator.speed = 1f;
        }
    }

    void FlipSprite()
    {
        if (horizontalInput == -1 && verticalInput == 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (horizontalInput == -1 && verticalInput == 1)
        {
            spriteRenderer.flipX = true;
        }
        else if (horizontalInput == -1 && verticalInput == -1)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }

    void MoveUnit(float horizontalInput, float verticalInput)
    {
        movement2D.Set(horizontalInput, verticalInput);
        movement2D = (movement2D.normalized * runSpeed) * Time.fixedDeltaTime;

        rigidBody2D.MovePosition(rigidBody2D.position + movement2D);
    }
    void OnCollisionEnter2D(Collision2D coll)
    { 
        if (coll.gameObject.tag == "yellowSchoolDress")
        {
            eWindow.addIteam("Yellow School Dress");
        }
    }   

} 











































