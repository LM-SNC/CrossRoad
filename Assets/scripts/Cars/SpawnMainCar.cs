using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMainCar : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(
           Player, new Vector3(0, 0, 0),
            Quaternion.Euler(-90, 0, 0)
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
