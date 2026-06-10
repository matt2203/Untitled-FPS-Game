using UnityEngine;

public class TriggerController : MonoBehaviour
{
    public GameObject SpawnManager;
  
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerMain")
        {
            SpawnManager.SetActive(true);
            Destroy(gameObject);
        }
    }
}
