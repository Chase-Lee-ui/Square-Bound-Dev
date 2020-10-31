using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Manager : MonoBehaviour
{
    private OverallScript find;
    public GameObject[] stars;
    public GameObject[] clears;
    // Start is called before the first frame update
    void Start()
    {
        find = GameObject.Find("Star Holder").GetComponent<OverallScript>();
    }


    // Update is called once per frame
    void Update()
    {
        if(find.starget(1))
        {
            stars[0].gameObject.SetActive(true);
        }

        if(find.starget(2))
        {
            stars[1].gameObject.SetActive(true);
        }

        if(find.starget(3))
        {
            stars[2].gameObject.SetActive(true);
        }

        if(find.starget(4))
        {
            stars[3].gameObject.SetActive(true);
        }

        if(find.clearscore(1))
        {
            clears[0].gameObject.SetActive(true);
        }

        if(find.clearscore(2))
        {
            clears[1].gameObject.SetActive(true);
        }

        if(find.clearscore(3))
        {
            clears[2].gameObject.SetActive(true);
        }

        if(find.clearscore(4))
        {
            clears[3].gameObject.SetActive(true);
        }
    }

    public void LoadScene1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void LoadScene4()
    {
        SceneManager.LoadScene("Level 4");
    }

    public void LoadScene5()
    {
        SceneManager.LoadScene("Level 5");
    }

    public void returnstage()
    {
        SceneManager.LoadScene("Stage Select");
    }

    public void loadcredit()
    {
        SceneManager.LoadScene("Credits");
    }

    public void leave()
    {
        Application.Quit();
    }
}
