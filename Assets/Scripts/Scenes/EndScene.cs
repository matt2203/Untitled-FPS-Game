using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Exp;
    public GameObject Ship;
    public Rigidbody rb;
    public float speed;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.AddRelativeForce(Vector3.back * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Trigger1")
        {
            Instantiate(Exp, Ship.transform.position, Ship.transform.rotation);
            Destroy(Ship);
        }

        if (other.tag == "Trigger2")
        {
            SceneManager.LoadScene(10);
        }
    }
}
