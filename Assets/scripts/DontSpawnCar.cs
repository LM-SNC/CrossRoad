using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontSpawnCar : MonoBehaviour
{
    public GameObject Player;

    private float position;

    public bool dontspawnotherscript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player = MainCar.inst;
        transform.position = Player.transform.position + new Vector3(0,12,0);
    }
    
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
          //  dontspawnotherscript = true;

        }
    }
}
