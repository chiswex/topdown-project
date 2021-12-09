using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [SerializeField] Transform hand;


    public float moveSpeed;

    public Rigidbody2D rb;

    public Animator anim;

    private Vector2 moveDirection;
    private Vector2 lastMoveDirection;


    void Update()
    {
        ProcessInputs();
        Animate();
        RotateHand();
    }
    
    void FixedUpdate()
    {
        Move();
    }

    void RotateHand()
    {
        float angle = Utility.AngleTowardsMouse(hand.position);
        hand.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical"); 

        
        if((moveX == 0 && moveY == 0) && moveDirection.x != 0 || moveDirection.y != 0)
        {
            lastMoveDirection = moveDirection;
        }

        moveDirection = new Vector2(moveX, moveY).normalized;
    }
    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

    }

    void Animate()
    {
        anim.SetFloat("AnimMoveX", moveDirection.x);
        anim.SetFloat("AnimMoveY", moveDirection.y);
        anim.SetFloat("Speed", moveDirection.magnitude);
        anim.SetFloat("AfterHorizontal", lastMoveDirection.x);
        anim.SetFloat("AfterVertical", lastMoveDirection.y);

    }

}
