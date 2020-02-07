using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptForRoad : MonoBehaviour
{
public GameObject road;
public GameObject[] roadnumbertwo;
public float speed = 1.8f;

public bool numbertwo;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnmap());
        Debug.Log("StartCoroutine:ScriptForRoad");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < -12)
        {
            if (!numbertwo)
            {
                Instantiate(road, new Vector3(0, 12, 0), Quaternion.identity);
                Destroy(gameObject);
            }

            else
            {
                Instantiate(roadnumbertwo[Random.Range(0,3)], new Vector3(0, 12, 0), Quaternion.identity);
                numbertwo = false;
            }
        }
    }

    IEnumerator spawnmap()
    {
        yield return new WaitForSeconds(Random.Range(1,3));
        Debug.Log("spawnmap():ScriptForRoad");
        numbertwo = true;
        
    }
}
