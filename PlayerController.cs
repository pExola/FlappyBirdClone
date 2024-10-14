using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb;
    [SerializeField] float moveSpeed;
    [SerializeField] float flyForce;
    bool canFly;
    bool isDead;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        rb.simulated = false;
    }


    private void Update()
    {
        if (!GameManager.instance.GameStarted && (Input.GetMouseButtonDown(0))) 
        { 
            GameManager.instance.StartGame();
            rb.simulated = true;
        }

        if (isDead) return;

        if (Input.GetMouseButtonDown(0)) {
            canFly = true;
        }

        RotatePlayer();
    }


    private void FixedUpdate()
    {
        if (isDead) return;
        Vector2 _velocity = new Vector2(moveSpeed, rb.velocity.y);
        rb.velocity = _velocity;

        if (canFly) Fly();
    }

    void Fly() { 
        
        canFly = false;
        Vector2 _velocity = rb.velocity;
        _velocity.y = 0;
        rb.velocity = _velocity;
        animator.SetTrigger("Fly");

        rb.AddForce(Vector2.up * flyForce);

    }

    private void OnCollisionEnter2D(Collision2D _other)
    {
     
        if (_other.collider.CompareTag("Pipe") || _other.collider.CompareTag("Ground") ) 
        { 
            Death();
        }
    }

    void Death() {

        isDead = true;
        animator.SetBool("isDead", isDead);
        GameManager.instance.GameOver();
    }

    void RotatePlayer()
    {
        float z = transform.eulerAngles.z;

        if (rb.velocity.y > 0)
            z = 10f;
        else
            z = Mathf.Lerp(0f, -90f, -rb.velocity.y / 3f);

        transform.eulerAngles = new Vector3(0, 0, z);  
    }
}
