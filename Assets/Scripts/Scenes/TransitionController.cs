using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionController : MonoBehaviour
{
    public GameObject Player;
    public GameObject PlayerSpawn;
    public GameObject MainUI;
    public GameObject EntryCam;
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
        Instantiate(Player, PlayerSpawn.transform.position, PlayerSpawn.transform.rotation);
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
