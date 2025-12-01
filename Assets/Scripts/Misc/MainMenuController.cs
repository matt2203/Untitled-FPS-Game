using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public KeyCode NextPage;
    public KeyCode PrevPage;
    public GameObject Page1;
    public GameObject Page2;
    public KeyCode ReturnToMenu;
    public GameObject MainMenu;
    public KeyCode OpenCtrlSheet;
    public GameObject CtrlSheet;
    public GameObject LevelSelect;
    public KeyCode OpenLevelSelect;




    void Update()
    {
        if (Input.GetKey(NextPage))
        {
            Page1.SetActive(false);
            Page2.SetActive(true);
        }

        if (Input.GetKey(PrevPage))
        {
            Page1.SetActive(true);
            Page2.SetActive(false);
        }

        if (Input.GetKey(OpenCtrlSheet))
        {
            MainMenu.SetActive(false);
            CtrlSheet.SetActive(true);
            LevelSelect.SetActive(false);
        }

        if (Input.GetKey(ReturnToMenu))
        {
            MainMenu.SetActive(true);
            CtrlSheet.SetActive(false);   
        }

        if (Input.GetKey(KeyCode.R))
        {
            LevelSelect.SetActive(false);
        }


        if (Input.GetKey(OpenLevelSelect))
        {
            MainMenu.SetActive(false);
            CtrlSheet.SetActive(false);
            LevelSelect.SetActive(true);
        }
        
        
    }
}
