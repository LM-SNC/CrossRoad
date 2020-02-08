using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DSpawnFIRST : MonoBehaviour
{
    public GameObject Player;

    private float position;

    public bool dontspawFIRST;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player = MainCar.inst;
        transform.position = new Vector3(transform.position.x,Player.transform.position.y + 12,0);
    }
    
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            dontspawFIRST = true;

        }
    }
}
