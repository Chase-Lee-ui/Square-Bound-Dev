using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    private Rigidbody2D r;
    
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 13.5)
        {
            transform.position = new Vector3(-13.5f, transform.position.y, 0.0f);
        }
        else if (transform.position.x < -13.5)
        {
            transform.position = new Vector3(13.5f, transform.position.y, 0.0f);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag(gameObject.tag))
        {
            //  gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            r.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
        else if (col.gameObject.CompareTag(gameObject.tag) == false)
        {
            // gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            r.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }
    }
}