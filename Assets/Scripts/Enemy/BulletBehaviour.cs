using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletBehaviour : MonoBehaviour

{
    public float speed = 10f;
    public float lifeTime = 20f;
 
    public int damage = 25;
    
 
    
    void Start()
    {
        Destroy(gameObject, lifeTime);
        GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * speed);
    }
 
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("PlayerMain"))
        {
            SceneManager.LoadScene(4);
        }
    }
    
}
 

