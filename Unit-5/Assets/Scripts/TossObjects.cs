using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TossObjects : MonoBehaviour
{
    Rigidbody objectRigidBody;

    playerLives playerLives;
    GameManager gm;

    void Start()
    {
        objectRigidBody = GetComponent<Rigidbody>();

        objectRigidBody.AddForce(Vector3.up * Random.Range(12, 17), ForceMode.Impulse);
        objectRigidBody.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);

        gm = GameObject.Find("GameMangaer").GetComponent<GameManager>();
        playerLives = GameObject.Find("lives").GetComponent<playerLives>();

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
            
            gm.lifeText(1);
        }
        Debug.Log("suckmynuts");
       
    }

    private void OnMouseDown()
    {
        if (gameObject.tag == "bad")
        {
            Destroy(gameObject);
            gm.updateScore(0);

            gm.lifeText(1);
        }
        else if (gameObject.tag == "good")
        {
            Destroy(gameObject);
            gm.updateScore(5);
        }
        
    }

   
}
