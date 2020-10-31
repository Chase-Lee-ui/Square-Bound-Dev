using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverallScript : MonoBehaviour
{
    public bool star1, star2, star3, star4;
    public bool clear1, clear2, clear3, clear4;
    public AudioSource playerAudio;
    // Start is called before the first frame update
    void Start()
    {
        star1 = false;
        star2 = false;
        star3 = false;
        star4 = false;
        clear1 = false;
        clear2 = false;
        clear3 = false;
        clear4 = false;
        playerAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(transform.gameObject);

        if(SceneManager.GetActiveScene().name == "Level 5")
        {
            playerAudio.Stop();
        }
    }

    public void IncreaseStars(bool stage, string stagename)
    {
        if(stage)
        {
            if(stagename == "Level 1")
            {
                star1 = true;
            }

            if(stagename == "Level 2")
            {
                star2 = true;
            }

            if(stagename == "Level 3")
            {
                star3 = true;
            }

            if(stagename == "Level 4")
            {
                star4 = true;
            }
        }
    }

    public void clearstage(string stagename)
    {
        if(stagename == "Level 1")
        {
            clear1 = true;
        }

        if(stagename == "Level 2")
        {
            clear2 = true;
        }

        if(stagename == "Level 3")
        {
            clear3 = true;
        }

        if(stagename == "Level 4")
        {
            clear4 = true;
        }
    }

    public bool starget(int i)
    {
        if(i == 1)
        {
            return star1;
        }
        else if(i == 2)
        {
            return star2;
        }
        else if(i == 3)
        {
            return star3;
        }
        else if(i == 4)
        {
            return star4;
        }
        else
        {
            return false;
        }
    }

    public bool clearscore(int i)
    {
        if(i == 1)
        {
            return clear1;
        }
        else if(i == 2)
        {
            return clear2;
        }
        else if(i == 3)
        {
            return clear3;
        }
        else if(i == 4)
        {
            return clear4;
        }
        else
        {
            return false;
        }
    }
}
