using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objects;
    playerLives playerLives;

    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        playerLives = GameObject.Find("lives").GetComponent<playerLives>();
        InvokeRepeating("spawnObjects", 2f, 2f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerLives.lives < 1 && !gameOver)
        {
            CancelInvoke("spawnObjects");

            gameOver = true;
        }
    }

    void spawnObjects()
    {
        int randomObject = Random.Range(0, 3);
        Vector3 randomRange = new Vector3(Random.Range(-5, 5), -5 , 0);
        Instantiate(objects[randomObject] ,randomRange, objects[0].transform.rotation);
    }

    void retry()
    {
        gameOver = false;

    }
}
