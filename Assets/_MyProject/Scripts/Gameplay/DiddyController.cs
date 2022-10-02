using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiddyController : MonoBehaviour
{

    Vector2 move;
    [SerializeField] private int speed;
    [SerializeField] int jumpPower;
    [SerializeField] float fallMultiplier;
    [SerializeField] private Camera mainCamera = null;
    public Animator animator;
    
    Rigidbody2D rb;

    public Transform groundCheck;
    public LayerMask groundLayer;
    bool isGrounded;
    Vector2 vecGravity;
 
    void Start()
    {
        mainCamera = Camera.main;
        vecGravity = new Vector2(0, -Physics2D.gravity.y);
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
       
       move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

       animator.SetFloat("speed", Mathf.Abs(move.x));

       isGrounded = Physics2D.OverlapCapsule(groundCheck.position,new Vector2(0.7f, 0.1f),CapsuleDirection2D.Horizontal, 0, groundLayer);

       if (Input.GetButtonDown("Jump") && isGrounded)
       {
        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        animator.SetBool("isJumping", true);
       }
       
       if (rb.velocity.y == 0)
       {
        animator.SetBool("isJumping", false);
       }

       if (rb.velocity.y < 0)
       {
        rb.velocity -= vecGravity * fallMultiplier * Time.deltaTime;
       }

       flip();

       var halfHeight = mainCamera.orthographicSize;
       var borderBottom = mainCamera.transform.position.y - halfHeight;
    
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(move.x * speed, rb.velocity.y);
    }

    void flip()
    {
        if (move.x < -0.01f) transform.localScale = new Vector2(-1, 1);
        if (move.x > 0.01f) transform.localScale = new Vector2(1, 1);
    }

}
