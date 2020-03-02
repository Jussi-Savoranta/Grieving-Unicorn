using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;
    public KeyCode action;

    [Header("Speed")]
    public float moveSpeed;
    public float jumpForce;

    [Header("Player Scale")]
    public float scale;

    [Header("Jump")]
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    public bool isGround;

    [Header("Misc")]
    public bool actionNow;
    public Transform actionSpot;
    public GameObject graveFlower;
    public bool noCry = false;

    private Rigidbody2D rb2d;
    private bool unicornTrigger;
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isGround = Physics2D.OverlapCircle(groundCheckPoint.position,
          groundCheckRadius,
          whatIsGround);
        unicornTrigger = GameObject.Find("dead unic").
        GetComponent<DeadUnicornTrigger>().unicornTrigger;

        if (rb2d.velocity.x > 0 || rb2d.velocity.x < 0 || rb2d.velocity.y > 0)
        {
            noCry = true;
        }

        MovePlayer();
        Animation();

    }

    private void Animation()
    {
        anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));

        anim.SetFloat("Speed y", Mathf.Abs(rb2d.velocity.y));

        anim.SetBool("Grounded", isGround);

        anim.SetBool("No Cry", noCry);
    }

    void MovePlayer()
    {
        if (GameObject.Find("Canvas").GetComponent<GameManager>().inIntro == true)
        {
            rb2d.velocity = new Vector2(0, 0);
        }
        else
        {
            if (Input.GetKeyDown(jump) && isGround == true)
            {
                rb2d.velocity = Vector2.up * jumpForce;

            }
          
            if (Input.GetKey(left))
            {
                rb2d.velocity = new Vector2(-moveSpeed, rb2d.velocity.y);
                transform.localScale = new Vector3(-scale, scale, 1);

            }
            else if (Input.GetKey(right))
            {
                rb2d.velocity = new Vector2(moveSpeed, rb2d.velocity.y);
                transform.localScale = new Vector3(scale, scale, 1);
            }
            else
            {
                rb2d.velocity = new Vector2(0, rb2d.velocity.y);

            }
        }
        if (Input.GetKeyDown(action))
        {
            actionNow = true;
        }
        else
        {
            actionNow = false;
        }

    }
}
