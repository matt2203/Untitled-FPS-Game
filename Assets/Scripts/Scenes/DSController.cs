using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DSController : MonoBehaviour
{
    public GameObject Dropship;
    public GameObject DropshipSpawn;
    public KeyCode SpawnDropship;




    void Update()
    {
        if (Input.GetKeyDown(SpawnDropship))
        {
            Instantiate(Dropship, DropshipSpawn.transform.position, DropshipSpawn.transform.rotation);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Dropship")
        {
            SceneManager.LoadScene(0);
        }
    }


    
}
