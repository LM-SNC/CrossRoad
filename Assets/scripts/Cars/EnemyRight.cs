using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyRight : MonoBehaviour
{
    public GameObject[] Cars;
    public GameObject[] CarsUp;
    private float[] positions = {-1.89f,-0.7f,0.64f,1.94f};
    int RandomPositionUP;
    int RandomPosition;
    private float ypos;
     bool[] dontspawn = {false,false,false,false,false,false,false,false};
     public GameObject[] DontSpawnCarsup;

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
            dontspawn[0] = DontSpawnCarsup[0].GetComponent<DSpawnFIRST>().dontspawFIRST;
            dontspawn[1] = DontSpawnCarsup[1].GetComponent<DSpawnSECOND>().dontspawnSECOND;
            dontspawn[2] = DontSpawnCarsup[2].GetComponent<DSpawnthirt>().dontspawnTHIRT;
            dontspawn[3] = DontSpawnCarsup[3].GetComponent<DSpawnFOURTH>().dontspawnFOURTH;
            
            dontspawn[4] = DontSpawnCarsup[4].GetComponent<DSPFIRST>().dspupFIRST;
            dontspawn[5] = DontSpawnCarsup[5].GetComponent<DSPSECOND>().dspupSECOND;
            dontspawn[6] = DontSpawnCarsup[6].GetComponent<DSPTHIRD>().dspupTHIRD;
            dontspawn[7] = DontSpawnCarsup[7].GetComponent<DSPFOURTH>().dspupFOURTH;
            
            
          

            
            
            RandomPositionUP = Random.Range(0, positions.Length);
            Debug.Log("EnemyRight-CARSUP||RandomPosition: " + RandomPositionUP);
            if (RandomPositionUP == 1 && !dontspawn[0])
            {
                Instantiate(
                    CarsUp[Random.Range(0, CarsUp.Length)],
                    new Vector3(positions[RandomPositionUP], ypos + 12, 0),
                    Quaternion.Euler(-90, 0, 0)
                );
            }
            else if(RandomPositionUP == 2 && !dontspawn[1])
            {
                Instantiate(
                    CarsUp[Random.Range(0, CarsUp.Length)],
                    new Vector3(positions[RandomPositionUP], ypos + 12, 0),
                    Quaternion.Euler(-90, 0, 0)
                );
            }
            else if(RandomPositionUP == 3 && !dontspawn[2])
            {
                Instantiate(
                    CarsUp[Random.Range(0, CarsUp.Length)],
                    new Vector3(positions[RandomPositionUP], ypos + 12, 0),
                    Quaternion.Euler(-90, 0, 0)
                );
            }
            else if(RandomPositionUP == 4 && !dontspawn[3])
            {
                Instantiate(
                    CarsUp[Random.Range(0, CarsUp.Length)],
                    new Vector3(positions[RandomPositionUP], ypos + 12, 0),
                    Quaternion.Euler(-90, 0, 0)
                );
            }
            else
            {
                Debug.Log("Fail spawn cars:EnemyRight");
            }


            
            
            RandomPosition = Random.Range(0, positions.Length);
            Debug.Log("EnemyRight-CARS||RandomPosition: " + RandomPosition);

            if (RandomPosition == 1 && !dontspawn[4])
            {
                Instantiate(
                    Cars[Random.Range(0, Cars.Length)],
                    new Vector3(positions[RandomPosition], ypos - 6, 0),
                    Quaternion.Euler(-90, 0, 0)
                );
            }
            else if (RandomPosition == 2 &&  !dontspawn[5])
            {
                {
                    Instantiate(
                        Cars[Random.Range(0, Cars.Length)],
                        new Vector3(positions[RandomPosition], ypos - 6, 0),
                        Quaternion.Euler(-90, 0, 0)
                    );
                }
            }
            else if (RandomPosition == 3 &&  !dontspawn[6])
            {
                {
                    Instantiate(
                        Cars[Random.Range(0, Cars.Length)],
                        new Vector3(positions[RandomPosition], ypos - 6, 0),
                        Quaternion.Euler(-90, 0, 0)
                    );
                }
            }
            else if (RandomPosition == 4 && !dontspawn[7])
            {
                {
                    Instantiate(
                        Cars[Random.Range(0, Cars.Length)],
                        new Vector3(positions[RandomPosition], ypos - 6, 0),
                        Quaternion.Euler(-90, 0, 0)
                    );
                }
            }


            yield return new WaitForSeconds(Random.Range(5,8));


        }
    }
}
