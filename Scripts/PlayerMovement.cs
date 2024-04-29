using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D rb;
    [SerializeField] float jumpForce;
    [SerializeField] float Speed;
    Animator animator;
    float MovementX;
    private BoxCollider2D boxCollider;
    [SerializeField] LayerMask Ground;

    enum AnimationStates { idle,running,jumping,falling};
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }
    void Update()
    {
         MovementX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(MovementX * Speed, rb.velocity.y);
         Jump();
         UpdateAnimationStates();
    }
    private void UpdateAnimationStates()
    {
        AnimationStates state;
        if (MovementX > 0)
        {
            transform.localScale = new Vector3(0.4654922f, 0.4654922f, 0f);
            state=AnimationStates.running;
         }
        else if (MovementX < 0)
        {
            transform.localScale = new Vector3(-0.4654922f, 0.4654922f, 0f);
            state = AnimationStates.running;
        }
        else
        {
            state = AnimationStates.idle;
        }
        if(rb.velocity.y > .1f)
        {
            state = AnimationStates.jumping;
        }
        else if(rb.velocity.y < -.1f)
        {
            state = AnimationStates.falling;
        }

        animator.SetInteger("State", (int)state);
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
        private bool IsGrounded()
        {
        return Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, .1f, Ground);
        }

}
