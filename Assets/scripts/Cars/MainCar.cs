using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCar : MonoBehaviour
{
    public float speed = 1;
    public float speedup = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        speedup = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        //moove
        transform.Translate(new Vector3(speed * Input.GetAxis("Horizontal") * Time.deltaTime,speedup * Time.deltaTime),0);

        if (Input.GetKey(KeyCode.W) && speedup < 2.5f)
        {
            speedup += 0.01f;
        }
        else if(speedup > 0)
        {
            speedup -= 0.02f;
        }

        if (Input.GetKey(KeyCode.S) && speedup > -3.5f)
        {
            speedup -= 0.009f;
        }
        else if(speedup < 0)
        {
            speedup += 0.02f;
        }
        //moove

        if (transform.position.y < -4f)
        {
            transform.position = new Vector3(transform.position.x, -4f, 0);
        }
        if (transform.position.y > 4f)
        {
            transform.position = new Vector3(transform.position.x, 4f, 0);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
