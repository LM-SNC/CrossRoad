using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefualtMapSpawn : MonoBehaviour
{
    
    public GameObject road;
    public float speed = 1.8f;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < -12)
        {
         
                Instantiate(road, new Vector3(0,12,0), Quaternion.identity);
            Destroy(gameObject);
        }

    }


}

