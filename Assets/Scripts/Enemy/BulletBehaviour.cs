using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletBehaviour : MonoBehaviour

{
    public float speed = 1000f;
    public float lifeTime = 100f;
    public float PlayerHP = 100f;
    public float EnemyDmg;
    
 
 void Start()
    {
        Destroy(gameObject, lifeTime);
        GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("PlayerMain"))
        {
            PlayerHP -= EnemyDmg;
            Destroy(gameObject);
        }
    }

}
 

