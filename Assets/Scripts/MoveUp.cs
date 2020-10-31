using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public float speed = 5;
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
        Vector2 direction = new Vector2(0, 1).normalized;
        playerRb.MovePosition(playerRb.position + (direction * speed * Time.fixedDeltaTime));
        if (transform.position.y > -4f)
        {
            transform.position = new Vector2(transform.position.x, -5f);
        }

    }
}
