using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 4700;

    public Rigidbody rb;
    public Animator playerAnimator;
    public GameObject ShootFX;
    public float ShootFXLifetime;
    private GameManager gameManager;
    public int Health = 100;
    public float PlayerHP = 100f;
    
    




    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(DeactivateObjectsAfterDelay(ShootFXLifetime));
        gameManager = FindFirstObjectByType<GameManager>().GetComponent<GameManager>();
    }

    void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.forward * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddRelativeForce(Vector3.left * speed);

        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddRelativeForce(Vector3.right * speed);
        }



        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(Vector3.back * speed);
        }

        if (Input.GetMouseButton(0))
        {
            ShootFX.SetActive(true);
        }
         if (PlayerHP <= 0)
            {
                SceneManager.LoadScene(4);
            }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "DropshipEnd")
        {
            SceneManager.LoadScene(4);
        }
    }

    IEnumerator DeactivateObjectsAfterDelay(float seconds)
    {
        while (true)
        {
            yield return new WaitForSeconds(seconds);

            GameObject[] objects = GameObject.FindGameObjectsWithTag("PlayerShootFX");
            foreach (GameObject obj in objects)
            {
                obj.SetActive(false);
            }
        }
    }          

    public void TakeDmg(int DmgToTake)
    {
        Health -= DmgToTake;
        gameManager.UpdateHealth(Health);
    }        
}
    

