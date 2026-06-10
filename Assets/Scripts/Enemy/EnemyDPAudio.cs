using UnityEngine;

public class EnemyDPAudio : MonoBehaviour
{
    public GameObject Audio;
    public GameObject AudioSpawn;
    void OnTriggerEnter(Collider other)
    {
         if (other.tag == "Ground")
        {
            Instantiate(Audio, AudioSpawn.transform.position, AudioSpawn.transform.rotation);
        }
}  }