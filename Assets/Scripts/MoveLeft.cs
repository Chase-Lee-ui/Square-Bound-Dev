using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public float speed = 5;
    public float xaxis, xaxisend;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Vector2 direction = new Vector2(-1, 0).normalized;
        playerRb.MovePosition(playerRb.position + (direction * speed * Time.fixedDeltaTime));
        if (transform.position.x < xaxisend)
        {
            transform.position = new Vector2(xaxis, transform.position.y);
        }

    }
}
