using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject EnemySpawn;
    
    void OnCollisionEnter(Collision collision)
    {
        Instantiate(Enemy, EnemySpawn.transform.position, EnemySpawn.transform.rotation);
        Destroy(EnemySpawn);
    }  
}
