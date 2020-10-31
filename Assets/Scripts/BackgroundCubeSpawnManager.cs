using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class BackgroundCubeSpawnManager : MonoBehaviour
{
    public GameObject[] cubes;
    int index;
    float xDir;
    float bound = 9.0f;
    public int i;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CubeSpawner", 0, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (i < 0)
        {
            CancelInvoke("CubeSpawner");
        }
    }

    void CubeSpawner()
    {
            Vector2 place = new Vector2(-bound, 5.5f);
            int index = Random.Range(0, cubes.Length);
            Instantiate(cubes[index], place, cubes[index].transform.rotation);

        bound = (float)(bound - 1.2);
        if (bound < -9)
        {
            bound = 9;
        }
        i--;
    }
}
