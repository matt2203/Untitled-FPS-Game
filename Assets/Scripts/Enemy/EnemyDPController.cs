using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDPController : MonoBehaviour
{
    public GameObject SpawnPoint1;
    public GameObject SpawnPoint2;
    public GameObject SpawnPoint3;
    public GameObject SpawnPoint4;
    public GameObject SpawnPoint5;
    public GameObject SpawnPoint6;
    public GameObject Enemy;
    public GameObject Exp;
    public GameObject ExpSpawn;
    public GameObject EnemySpawn;
    public GameObject EnemyDP;



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ST1")
        {
             Debug.Log("Detected");
            Instantiate(EnemyDP, SpawnPoint1.transform.position, SpawnPoint1.transform.rotation);
            Instantiate(EnemyDP, SpawnPoint2.transform.position, SpawnPoint2.transform.rotation);
            Instantiate(EnemyDP, SpawnPoint3.transform.position, SpawnPoint3.transform.rotation);
            Instantiate(EnemyDP, SpawnPoint4.transform.position, SpawnPoint4.transform.rotation);
            Instantiate(EnemyDP, SpawnPoint5.transform.position, SpawnPoint5.transform.rotation);
            Instantiate(EnemyDP, SpawnPoint6.transform.position, SpawnPoint6.transform.rotation);
        }
           
        
         if (other.tag == "Ground")
            {
                Instantiate(Exp, ExpSpawn.transform.position, ExpSpawn.transform.rotation);
                Instantiate(Enemy, EnemySpawn.transform.position, EnemySpawn.transform.rotation);
                Destroy(gameObject);
            }
    }
}
