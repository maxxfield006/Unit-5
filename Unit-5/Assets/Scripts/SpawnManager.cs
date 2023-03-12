using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objects;
    playerLives playerLives;

    public bool gameOver = false;

    Button retryButton;

    // Start is called before the first frame update
    void Start()
    {
        playerLives = GameObject.Find("lives").GetComponent<playerLives>();
        InvokeRepeating("spawnObjects", 2f, 2f);

        retryButton = GameObject.Find("retryButton").GetComponent<Button>();
        retryButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.FindGameObjectWithTag("retryButton").SetActive(false);

        if (playerLives.lives < 1 && !gameOver)
        {
            CancelInvoke("spawnObjects");
            gameOver = true;
            retryButton.gameObject.SetActive(true);
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
        playerLives.lives += 3;
        retryButton.gameObject.SetActive(false);
    }
}
