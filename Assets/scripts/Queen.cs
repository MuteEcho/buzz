using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float limitLeft = -10f;
    public float spawnRight = 10f;
    public float spawnMax = 5f;
    public float spawnMin = -5f;
    public Rigidbody2D rb;
    public GameObject redBoi;

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
            Instantiate(redBoi);
            moveSpeed = moveSpeed + 1.5f;

        }

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
