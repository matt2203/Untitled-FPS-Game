using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitController : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
   
    void Start()
    {
       rb = GetComponent<Rigidbody>();                              
    }

    
    void FixedUpdate()
    {
        rb.AddRelativeForce(Vector3.forward * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(0);
    }

}
    
        

        

