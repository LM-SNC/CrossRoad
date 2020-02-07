using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefualtMapSpawn : MonoBehaviour
{
    public float POSy;
    public GameObject road;
    public float speed = 1.8f;
    // Start is called before the first frame update
    private void Start()
    {
        POSy = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y > POSy +6)
        {
            Instantiate(road, new Vector3(0,transform.position.y + 12,0), Quaternion.identity);
            POSy += 6;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(road);
        }

    }


}

