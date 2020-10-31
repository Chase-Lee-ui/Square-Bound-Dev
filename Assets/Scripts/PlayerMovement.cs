using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Video;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private bool alive;
    public GameObject gameover;
    public GameObject win;
    private Rigidbody2D playerRb;
    public int speed = 5;
    public float xaxis = 14;
    public OverallScript find;
    private bool gotten;

    // Start is called before the first frame update
    void Start()
    {
        alive = true;
        gotten = false;
        playerRb = GetComponent<Rigidbody2D>();
        find = GameObject.Find("Star Holder").GetComponent<OverallScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // if(alive)
        // {
        //     Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        //     if (transform.position.x > 14)
        //     {
        //         transform.position = new Vector3(-14.0f, transform.position.y, 0.0f);
        //     }
        //     else if (transform.position.x < -14)
        //     {
        //         transform.position = new Vector3(14.0f, transform.position.y, 0.0f);
        //     } 

        //     transform.position += movement * Time.deltaTime * movementSpeed;
        // }


    }

    void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Horizontal");
        Vector2 direction = new Vector2(v, 0).normalized;
        playerRb.MovePosition(playerRb.position+(direction*speed*Time.fixedDeltaTime));
        if(transform.position.x < -xaxis)
        {
            transform.position = new Vector2(xaxis - 0.2f, transform.position.y);
        }
        else if(transform.position.x > xaxis)
        {
            transform.position = new Vector2(-xaxis + 0.2f, transform.position.y);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Laser"))
        {
            GameOver();
        }
        if(collision.gameObject.CompareTag("Win"))
        {
            Win();

        }
        if(collision.gameObject.tag == "Stars")
        {
            Destroy(collision.gameObject);
            gotten = true;
        }
    }

    private void GameOver()
    {
        alive = false;
        Destroy(gameObject);
        gameover.gameObject.SetActive(true);
    }

    private void Win()
    {
        if(alive)
        {
            find.IncreaseStars(gotten, SceneManager.GetActiveScene().name);
            find.clearstage(SceneManager.GetActiveScene().name);
            Destroy(gameObject);
            win.gameObject.SetActive(true);
            
        }
    }

}
