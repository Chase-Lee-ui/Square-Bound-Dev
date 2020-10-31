using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public int speed = 5;
    public float yaxisend;
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
        Vector2 direction = new Vector2(0, -1).normalized;
        playerRb.MovePosition(playerRb.position + (direction * speed * Time.fixedDeltaTime));
        if (transform.position.y < yaxisend)
        {
            Destroy(gameObject);
        }
    }
}
