using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletBehaviour : MonoBehaviour

{
    public float speed = 1000f;
    public float lifeTime = 100f;
    public float PlayerHP = 100f;
    public float EnemyDmg;
    public float BulletLifetime;
    
 
 void Start()
    {
        Destroy(gameObject, lifeTime);
        GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * speed);
         StartCoroutine(DestroyObjectsAfterDelay(BulletLifetime));
    }

    void Update()
    {
        if(PlayerHP <= 0)
        {
            Debug.Log("Game Over");
        }

        

        
    }


    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("PlayerMain"))
        {
             PlayerHP -= EnemyDmg;
        }
        
    }
    IEnumerator DestroyObjectsAfterDelay(float seconds)
    {
        while (true)
        {
            yield return new WaitForSeconds(seconds);

            Destroy(gameObject);
        }
    } 
}
 

