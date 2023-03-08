using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TossObjects : MonoBehaviour
{
    Rigidbody objectRigidBody;

    void Start()
    {
        objectRigidBody = GetComponent<Rigidbody>();

        objectRigidBody.AddForce(Vector3.up * Random.RandomRange(10, 16), ForceMode.Impulse);
        objectRigidBody.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }


}
