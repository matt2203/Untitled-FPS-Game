using System;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    public GameObject SpawnPoint;
    public GameObject SpawnTrigger;
    public GameObject SpawnController;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SpawnTrigger")
        {
            Instantiate(SpawnController, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
           
        }
    }
}
