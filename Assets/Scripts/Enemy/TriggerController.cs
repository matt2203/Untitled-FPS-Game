using UnityEngine;

public class TriggerController : MonoBehaviour
{
    public GameObject SpawnManager;
  
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerMain")
        {
            Debug.Log("Detected");
            SpawnManager.SetActive(true);
            Destroy(gameObject);
        }
    }
}
