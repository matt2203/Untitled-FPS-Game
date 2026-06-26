using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionController : MonoBehaviour
{
    public GameObject Player;
    public GameObject MainUI;
    public GameObject EntryCam;
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
        Player.SetActive(true);
        EntryCam.SetActive(false);
        MainUI.SetActive(true);    
        }
         if (other.tag == "Scene Trigger")
        {
            SceneManager.LoadScene(1);
        }

       if (other.tag == "Scene Trigger 2")
        {
            SceneManager.LoadScene(6);
       }
    }
}
