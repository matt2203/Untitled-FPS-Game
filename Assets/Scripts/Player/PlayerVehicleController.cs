using Unity.VisualScripting;
using UnityEngine;

public class PlayerVehicleController : MonoBehaviour
{
    public float speed;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Engine Light")
        {
            Destroy(gameObject);
        }
    }
}
