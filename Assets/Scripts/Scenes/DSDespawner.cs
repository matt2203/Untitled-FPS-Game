using UnityEngine;

public class DSDespawner : MonoBehaviour
{


    void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            Destroy(gameObject);
        }
    }
        
}
