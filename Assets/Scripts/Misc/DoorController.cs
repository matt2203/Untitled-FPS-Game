using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public KeyCode OpenDoor = KeyCode.E;
    public GameObject DoorClosed;
    public GameObject DoorOpen;
    public GameObject Explosion;
    public GameObject ExpSpawn;
    public GameObject promptUI;
    public GameObject DetectionCollider;
    

    public bool playerInside = false;

    void Update()
    {
        if (playerInside && Input.GetKeyDown(OpenDoor))
        {
             DoorClosed.SetActive(false);
            DoorOpen.SetActive(true);
            Destroy(promptUI);
            Destroy(DetectionCollider);
            Instantiate(Explosion, ExpSpawn.transform.position, ExpSpawn.transform.rotation);
            if (promptUI != null) promptUI.SetActive(false); 
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerMain"))
        {
            playerInside = true;
            if (promptUI != null) promptUI.SetActive(true); 
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerMain"))
        {
            playerInside = false;
            if (promptUI != null) promptUI.SetActive(false); 
        }
    }
}
