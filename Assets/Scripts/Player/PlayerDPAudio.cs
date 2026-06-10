using UnityEngine;

public class PlayerDPAudio : MonoBehaviour
{
    public GameObject Audio;
    public GameObject AudioSpawn;
    void OnTriggerEnter(Collider other)
    {
         if (other.tag == "Ground")
        {
            Debug.Log("Detected");
            Instantiate(Audio, AudioSpawn.transform.position, AudioSpawn.transform.rotation);
            
        }
}  }
