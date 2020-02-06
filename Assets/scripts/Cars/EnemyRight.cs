using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyRight : MonoBehaviour
{
    public GameObject[] Cars;
    private float[] positions = {0.64f,1.94f};
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCar());
    }

    // Update is called once per frame
  

    IEnumerator SpawnCar()
    {
        while (true)
        {
            Instantiate(
                Cars[Random.Range(0, Cars.Length)], new Vector3(positions[Random.Range(0, positions.Length)], -15, 0),
                Quaternion.Euler(-90, 0, 0)
            );
            yield return new WaitForSeconds(Random.Range(3,6));


        }
    }
}
