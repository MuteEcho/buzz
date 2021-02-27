using System.Collections;
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
        else if (rb.transform.position.y < maxDown)
        {
            rb.MovePosition(new Vector2(rb.position.x, maxDown));
        }
        else if (rb.transform.position.x > maxRight)
        {
            rb.MovePosition(new Vector2(maxRight, rb.position.y));
        }
        else if (rb.position.x < maxLeft)
        {
            rb.MovePosition(new Vector2(maxLeft, rb.position.y));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("you died");
        Application.LoadLevel("LevelOne");
    }
}
