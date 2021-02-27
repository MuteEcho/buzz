using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float moveSpeedMin = 3f;
    public float moveSpeedMax = 10f;
    public float limitLeft = -10f;
    public float spawnRight = 10f;
    public float spawnMax = 5f;
    public float spawnMin = -5f;
    public Rigidbody2D rb;

    Vector2 movement;
    Vector2 spawn;

    private void Start()
    {
        spawn.x = spawnRight;
        spawn.y = 0;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = -1;

        if (rb.position.x < limitLeft)
        {
            spawn.y = Random.Range(spawnMin, spawnMax);
            rb.position = spawn;
            moveSpeed = Random.Range(moveSpeedMin, moveSpeedMax);

            float chance = Random.Range(0, 100);
            if (chance > 90)
            {
                moveSpeed = moveSpeed * 2;
            }

            
        }

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
