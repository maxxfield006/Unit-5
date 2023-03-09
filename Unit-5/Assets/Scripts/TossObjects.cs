using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TossObjects : MonoBehaviour
{
    Rigidbody objectRigidBody;

    GameManager gm;


    public int lives;
  
    public bool gameOver = false;

    void Start()
    {
        objectRigidBody = GetComponent<Rigidbody>();

        objectRigidBody.AddForce(Vector3.up * Random.Range(10, 16), ForceMode.Impulse);
        objectRigidBody.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);

        gm = GameObject.Find("GameMangaer").GetComponent<GameManager>();

        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }

        if (lives == 0)
        {
            gameOver = true;
        }
    }

    private void OnMouseDown()
    {
        if (gameObject.tag == "bad")
        {
            Destroy(gameObject);
            gm.updateScore(0);

            lives--;
            Debug.Log(lives);
        }
        else if (gameObject.tag == "good")
        {
            Destroy(gameObject);
            gm.updateScore(5);
        }
        
    }

   
}
