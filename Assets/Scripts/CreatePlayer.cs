using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayer : MonoBehaviour
{
    public GameObject pushedButton;
    public GameObject[] CorrespondingLaser;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(gameObject.tag))
        {
            gameObject.SetActive(false);
            pushedButton.gameObject.SetActive(true);
            for (int i = 0; i < CorrespondingLaser.Length; i++)
            {
                Destroy(CorrespondingLaser[i].gameObject);
            }
        }
        else if (other.gameObject.CompareTag(gameObject.tag) == false)
        {
            gameObject.SetActive(true);
            pushedButton.gameObject.SetActive(false);
        }
    }
}
