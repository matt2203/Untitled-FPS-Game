using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletBehaviour : MonoBehaviour

{
    public float speed = 1000f;
    public float lifeTime = 100f;
    public int EnemyDmg;
    
 
 void Start()
    {
        Destroy(gameObject, lifeTime);
        GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * speed);
    }


    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("PlayerMain"))
        {
            collision.gameObject.GetComponent<PlayerController>().Damage(EnemyDmg);
        } 
        Destroy(gameObject);
    }
}
 

