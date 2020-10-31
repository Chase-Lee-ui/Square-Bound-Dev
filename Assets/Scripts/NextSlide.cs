using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSlide : MonoBehaviour
{
    public GameObject nextSlide;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(delay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(24);
        newslide();
    }

    void newslide()
    {
        nextSlide.gameObject.SetActive(true);
    }
}
