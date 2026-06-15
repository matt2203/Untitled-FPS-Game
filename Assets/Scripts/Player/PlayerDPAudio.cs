using UnityEngine;

public class PlayerDPAudio : MonoBehaviour
{
    public GameObject Audio;
    public GameObject AudioSpawn;

    void OnCollisionEnter(Collision collision)
    {
        Instantiate(Audio, AudioSpawn.transform.position, AudioSpawn.transform.rotation);
        AudioSpawn.SetActive(false);
    }
}
