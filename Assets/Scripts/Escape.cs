using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour
{
    public GameObject escapewindow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !escapewindow.activeInHierarchy)
        {
            escapewindow.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && escapewindow.activeInHierarchy)
        {
            escapewindow.gameObject.SetActive(false);
            Time.timeScale = 1;   
        }
    }

    public void returnmain()
    {
        SceneManager.LoadScene("Stage Select");
    }

    public void exit()
    {
        Application.Quit();
    }
}
