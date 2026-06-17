using UnityEngine;

public class PlayerDPAudio : MonoBehaviour
{
    public GameObject Audio;
    public GameObject AudioSpawn;
    public GameObject AudioSource;

    void OnCollisionEnter(Collision collision)
    {
        Instantiate(Audio, AudioSpawn.transform.position, AudioSpawn.transform.rotation);
        AudioSpawn.SetActive(false);
        AudioSource.SetActive(false);
    }
}
