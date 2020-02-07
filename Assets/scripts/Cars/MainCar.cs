using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MainCar : MonoBehaviour
{
    public float speed = 1;
    public float speedup = 0.5f;

    public static GameObject inst;
    // Start is called before the first frame update
    void Start()
    {
        speedup = 0.5f;
        if (!MainCar.inst)
        {
            MainCar.inst = gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //moove
        transform.Translate(new Vector3(speed * Input.GetAxis("Horizontal") * Time.deltaTime,speedup * Time.deltaTime),0);

        if (Input.GetKey(KeyCode.W) && speedup < 3f)
        {
            speedup += 0.01f;
        }
        else if(speedup > 1.5)
        {
            speedup -= 0.02f;
        }

        if (Input.GetKey(KeyCode.S) && speedup > 1f)
        {
            speedup -= 0.009f;
        }
        //moove


    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
