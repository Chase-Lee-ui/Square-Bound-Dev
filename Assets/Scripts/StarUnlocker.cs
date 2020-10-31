using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarUnlocker : MonoBehaviour
{
    public OverallScript find;
    public GameObject[] blocker;
    public GameObject buttongoodend, buttonbadend, player;
    // Start is called before the first frame update
    void Start()
    {
        find = GameObject.Find("Star Holder").GetComponent<OverallScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null)
        {
            if(find.starget(1))
            {
                blocker[0].gameObject.SetActive(false);
            }

            if(find.starget(2))
            {
                blocker[1].gameObject.SetActive(false);
            }

            if(find.starget(3))
            {
                blocker[2].gameObject.SetActive(false);
            }

            if(find.starget(4))
            {
                blocker[3].gameObject.SetActive(false);
            }
        }

        if(find.starget(1) && find.starget(2) && find.starget(3) && find.starget(4))
        {
            buttongoodend.gameObject.SetActive(true);
        }
        else
        {
            buttonbadend.gameObject.SetActive(true);
        }
    }
}
