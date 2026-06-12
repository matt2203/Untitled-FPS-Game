using UnityEngine;

public class DPAudio : MonoBehaviour
{
    public GameObject Audio;
    public GameObject AudioSpawn;
    public GameObject AudioSpawn2;

    void OnTriggerEnter(Collider other)
    {
        Instantiate(Audio, AudioSpawn2.transform.position, AudioSpawn2.transform.rotation);
    }

    void OnCollisionEnter(Collision collision)
    {
        Instantiate(Audio, AudioSpawn.transform.position, AudioSpawn.transform.rotation);
    }


}  
