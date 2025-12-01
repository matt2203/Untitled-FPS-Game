using UnityEngine;

public class BossController : MonoBehaviour
{
    public GameObject PlayerLink;


    void Start()
    {
#pragma warning disable CS0618 
        PlayerLink = FindObjectOfType<PlayerController>().gameObject;
 
    }

    void Update()
    {
        transform.LookAt(new Vector3(PlayerLink.transform.position.x, transform.position.y, PlayerLink.transform.position.z));
        transform.Rotate(0, 270, 0);
    }
}
