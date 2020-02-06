using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EnemyMoover : MonoBehaviour
{
    public float speed = 2;
    public float speedmoove = 1f;

    public bool right;
    public bool left;
    // Start is called before the first frame update

    public float x;
    public float y;
    public float z;
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Right"))
        {

        }
    }



    public void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("MOOV"))
        {
     
                if (transform.position.x < 2 && transform.position.x > 1.3f)
                {
                    left = true;
                   
                }

                if (transform.position.x > -0.01f && transform.position.x < 1.3f)
                {
                    right = true;
                }
                
        }



    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (right && transform.position.x < 2)
        {
            transform.Translate(Vector3.right * speedmoove * Time.deltaTime);
            if (transform.position.x >= 2)
            {
                right = false;
            }
        }
        if (left && transform.position.x > 0.64f)
        {
            transform.Translate(Vector3.left * speedmoove * Time.deltaTime);
            if (transform.position.x <= 0.64f)
            {
                left = false;
            }
        }

        if (transform.position.y > 8f)
        {
            Destroy(gameObject);
        }
    }

}
