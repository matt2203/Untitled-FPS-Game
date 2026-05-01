using UnityEngine;

public class EnemyGunController : MonoBehaviour

{

 public float rotationSpeed = 20f;

 public GameObject Firepoint;

 public GameObject Bullet;

 public float fireRate = 5f;

 public float startDelay = 5f;

 public GameManager gameManager;

    [System.Obsolete]
    void Start()

 {

 gameManager = FindObjectOfType<GameManager>().GetComponent<GameManager>();

 InvokeRepeating("ShootPlayer", fireRate, startDelay);
 }


 void ShootPlayer()

 {

 Instantiate(Bullet, Firepoint.transform.position, Firepoint.transform.rotation);
}

}