using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyMoover : MonoBehaviour
{
    public GameObject Player;
    public float speed = 2;
    public float speedmoove = 1f;
    public bool right;
    public bool speeddown;
    public bool left;
    // Start is called before the first frame update
    
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("MOOV"))
        {
            
            if (speed > 1)
            {
                speed -= 0.3f;
            }

            StartCoroutine(CheckSpeed());
        }
    }

    private void Start()
    {
     
        Player = MainCar.inst;
        
    }


    public void OnTriggerEnter(Collider other)
    {






    }

    // Update is called once per frame
    void Update()
    {
        
        if (Player.transform.position.y > transform.position.y + 15)
        {
            Debug.Log("CheckPosY:Destroy");
            Destroy(gameObject);
        } 
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

      /*  if (right && transform.position.x < 2)
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
        */

     //   if (transform.position.y > 8f)
      //  {
      //      Destroy(gameObject);
      //  }
    }
    IEnumerator CheckSpeed()
    {
        yield return new WaitForSeconds(Random.Range(7,10));
        if (speed < 2 && !speeddown)
        {
            speed += 0.01f;
        }

        

    }
}
