using Unity.VisualScripting;
using UnityEngine;

public class PlayerVehicleController : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OTriggerEnter(Collider other)
    {
        if (other.tag == "Engine Light")
        {
            Destroy(gameObject);
        }
    }
}
