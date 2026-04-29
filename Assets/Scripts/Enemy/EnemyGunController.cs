using UnityEngine;

public class EnemyGunController : MonoBehaviour

{

 public float rotationSpeed = 20f;

 public GameObject firePointLink;

 public GameObject normalShell;

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

 Instantiate(normalShell, firePointLink.transform.position, firePointLink.transform.rotation);
}

}