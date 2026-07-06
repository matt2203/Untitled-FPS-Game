using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject PlayerLink;
    public GameObject Player;
    public float Speed;
    public float StopDistance;
    void Start()
    {
#pragma warning disable CS0618 
        PlayerLink = FindObjectOfType<PlayerController>().gameObject;
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        float currentDistance = Vector3.Distance(transform.position, Player.transform.position); 
        transform.LookAt(Player.transform.position);
        Debug.Log("Player is at: " + Player.transform.position);
        //transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, Speed);
        Debug.Log("Enemy is at: " + transform.position);
        if (currentDistance > StopDistance) 
        { transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, Speed); }
    }
}
