using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyRight : MonoBehaviour
{
    public GameObject[] Cars;
    public GameObject[] CarsUp;
    private float[] positions = {0.64f,1.94f,-1.89f,-0.7f};
    private float ypos;
    private bool dontspawn;
    public GameObject DontSpawnCars;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCar());
    }

    // Update is called once per frame
    private void Update()
    {
        
        ypos = transform.position.y;
    }

    IEnumerator SpawnCar()
    {
        while (true)
        {
            
            Instantiate(
                              Cars[Random.Range(0, Cars.Length)], new Vector3(positions[Random.Range(0, positions.Length)], ypos - 6, 0),
                              Quaternion.Euler(-90, 0, 0)
                          );
            dontspawn = DontSpawnCars.GetComponent<DontSpawnCar>().dontspawnotherscript;
            if (!dontspawn)
            {
                Instantiate(
                    CarsUp[Random.Range(0, CarsUp.Length)],
                    new Vector3(positions[Random.Range(0, positions.Length)], ypos + 12, 0),
                    Quaternion.Euler(-90, 0, 0)
                );
            }
            else
            {
                Debug.Log("Неудача!:" + dontspawn);
            }

            yield return new WaitForSeconds(Random.Range(7,12));


        }
    }
}
