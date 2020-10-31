using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft2 : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public int speed = 5;
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
        if (transform.position.x < -1.59)
        {
            transform.position = new Vector2(16f, transform.position.y);
        }

    }
}
