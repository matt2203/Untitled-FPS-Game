using UnityEngine;
using UnityEngine.SceneManagement;

public class DPController : MonoBehaviour
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
    }
}
