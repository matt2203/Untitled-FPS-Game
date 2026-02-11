using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public KeyCode PressButton = KeyCode.E;
    public GameObject promptUI;
    public GameObject DetectionCollider;
    

    public bool playerInside = false;

    void Update()
    {
        if (playerInside && Input.GetKeyDown(PressButton))
        {
            SceneManager.LoadScene(9);
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