using UnityEngine;

public class SpawnTrigger : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject Enemy5;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerMain")
        {
            Debug.Log("Detected");
            Enemy1.SetActive(true);
        }

        if (other.tag == "PlayerMain")
        {
            Debug.Log("Detected");
            Enemy2.SetActive(true);
        }

        if (other.tag == "PlayerMain")
        {
            Debug.Log("Detected");
            Enemy3.SetActive(true);
        }

        if (other.tag == "PlayerMain")
        {
            Debug.Log("Detected");
            Enemy4.SetActive(true);
        }

        if (other.tag == "PlayerMain")
        {
            Debug.Log("Detected");
            Enemy5.SetActive(true);
        }
    }
}
