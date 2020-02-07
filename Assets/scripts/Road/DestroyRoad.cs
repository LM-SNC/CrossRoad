using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyRoadForSecond());
    }

    // Update is called once per frame

    IEnumerator DestroyRoadForSecond()
    {
        yield return new WaitForSeconds(30);
            Destroy(gameObject);
            
        }
    }


