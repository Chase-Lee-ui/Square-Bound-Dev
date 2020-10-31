using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManyButtonDoor : MonoBehaviour
{
    public GameObject[] buttonspushed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int satisfied = 0;
        for(int i = 0; i<buttonspushed.Length; i++)
        {
            if(buttonspushed[i].activeInHierarchy == true)
            {
                satisfied++;
            }
            
            if(satisfied == buttonspushed.Length)
            {
                Destroy(gameObject);
            }
        }
    }
}
