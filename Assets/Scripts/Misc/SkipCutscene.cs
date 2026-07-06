using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SkipCutscene : MonoBehaviour
{
    public KeyCode SkipDrop;
    public GameObject PlayerDP;
    public GameObject UI;
    public GameObject Player;
    public GameObject PlayerDPLanded;
    public KeyCode SkipScene;
    public int Scene;
    
    void Update()
    {
        if (Input.GetKey(SkipDrop))
        {
            PlayerDP.SetActive(false);
            PlayerDPLanded.SetActive(true);
            UI.SetActive(true);
            Player.SetActive(true);
        }

        if (Input.GetKey(SkipScene))
        {
            SceneManager.LoadScene(Scene);
        }
    }
}
