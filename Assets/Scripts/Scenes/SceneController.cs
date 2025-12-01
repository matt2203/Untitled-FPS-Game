using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    public KeyCode Level1;
    public KeyCode AimTrainer;
    public KeyCode ATReturn;
    public KeyCode Quit;
    public KeyCode QuitStop;
    public GameObject MainMenu;
    public GameObject QuitConfirm;
    public KeyCode QuitConfirmed;




    void Update()
    {

        if (Input.GetKey(AimTrainer))
        {
            SceneManager.LoadScene(2);
        }
        if (Input.GetKey(ATReturn))
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKey(Level1))

        {
            SceneManager.LoadScene(5);
        }
        if (Input.GetKey(Quit))
        {
            MainMenu.SetActive(false);
            QuitConfirm.SetActive(true);
        }

        if (Input.GetKey(QuitStop))
        {
            MainMenu.SetActive(true);
            QuitConfirm.SetActive(false);
        }

        if (Input.GetKey(QuitConfirmed))
        {
            Application.Quit();
        }
        
        



    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Door Trigger Scene 1.5")
        {
            SceneManager.LoadScene(3);   
        }
            
    }
} 


    
    
    
  


