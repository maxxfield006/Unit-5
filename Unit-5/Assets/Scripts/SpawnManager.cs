using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objects;

    float xRange = 5;

    TossObjects tossObjectsScript;
    void Start()
    {
        InvokeRepeating("spawnObjects", 3f, 3f);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnObjects()
    {
        int randomRange = Random.Range(-5, 5);
        int randomObject = Random.Range(0, 3);

        Instantiate(objects[randomObject], new Vector3(randomRange, -3, 0), transform.rotation);
    }
}
