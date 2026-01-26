using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionController : MonoBehaviour
{
    public GameObject Player;
    public GameObject Exp;
    public GameObject ExpSpawn;
    public GameObject MainUI;
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
            MainUI.SetActive(true);
            Instantiate(Exp, ExpSpawn.transform.position, ExpSpawn.transform.rotation);
            Player.SetActive(true);
            Destroy(gameObject);
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
