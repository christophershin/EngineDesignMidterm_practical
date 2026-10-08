using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    [HideInInspector]
    public float horizontal;
    private bool isFacingRight = false;

    public int MaxPlayerHP = 4;
    private int PlayerHP;
    //public Slider PlayerHealthBar;

    private float speed;
    private float jumpingPower;
    private float gravityMultiplier;
    private bool doubleJumpCooldown;
    [SerializeField] private float maxGravityMulti;
    public float MaxVelocityY = 15f;
    [SerializeField] private float minFallingActivation;
    [SerializeField] private Camera _mainCamera;


    public int playerscore;
    public TMP_Text score;
    


    private Rigidbody2D rb;
    [SerializeField] private Transform GroundCheck;
    [SerializeField] private LayerMask groundLayer;


    void Start()
    {
        PlayerHP = MaxPlayerHP;
        Time.timeScale = 1.0f;
        rb = GetComponent<Rigidbody2D>();
    }





    void Update()
    {


            horizontal = Input.GetAxisRaw("Horizontal");


            // jumping 
            if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
            {

                gravityMultiplier = 0f;
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpingPower);
                doubleJumpCooldown = true;

            }

            // double jump
            if (Input.GetKeyDown(KeyCode.Space) && !IsGrounded() && doubleJumpCooldown == true)
            {


                doubleJumpCooldown = false;
                gravityMultiplier = 0f;
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpingPower);


            }


            Flip();
        



        fakeGravity();


        if (PlayerHP <= 0)
        {
            PlayerHP = 0;
            Debug.Log("GAME OVER");

        }




        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.identity, 3 * Time.deltaTime);

    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);


    }



    public bool IsGrounded()
    {
        return Physics2D.OverlapCircle(GroundCheck.position, 0.2f, groundLayer);
    }


    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }

    }






    void fakeGravity()
    {
        if (rb.linearVelocity.y > MaxVelocityY * -1)
        {
            if (rb.linearVelocity.y < minFallingActivation && !IsGrounded())
            {

                gravityMultiplier += Time.deltaTime;

                if (gravityMultiplier > maxGravityMulti)
                {
                    rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * 1.5f);

                    gravityMultiplier = 0f;
                }

            }
            else
            {
                gravityMultiplier = 0f;
            }
        }
    }






    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "DeathBox")
        {
            PlayerHP = 0;
        }


        if (collision.gameObject.layer == 3)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0f);
        }

        if (collision.gameObject.tag == "Bomb")
        {
            collision.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bomb")
        {
            collision.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }


    public void TakeDamage(int num)
    {
        PlayerHP -= num;

    }


    public int getPlayerHealth()
    {
        return PlayerHP;
    }

    public float getPlayerSpeed()
    {
        return speed;
    }




}
