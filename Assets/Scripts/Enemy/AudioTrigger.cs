using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
public GameObject AudioSource;
public GameObject AudioSpawn;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PlayerMain")
        {
            
        }

        if(other.tag == "Ground")
        {
            Destroy(AudioSource);
        }
    }
}
