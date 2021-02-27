﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movebaby : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public float maxUp;
    public float maxDown;
    public float maxLeft;
    public float maxRight;

    Vector2 movement;
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        if (rb.transform.position.y > maxUp)
        {
            rb.MovePosition(new Vector2(rb.position.x, maxUp));
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("you died");
        Application.LoadLevel("LevelOne");
    }
}