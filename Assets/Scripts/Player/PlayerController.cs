using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 4700;

    public Rigidbody rb;
    public Animator playerAnimator;
    public GameObject ShootFX;
    public float ShootFXLifetime;




    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
        playerAnimator.SetBool("isMoving", false);
        StartCoroutine(DeactivateObjectsAfterDelay(ShootFXLifetime));

    }


    void FixedUpdate()
    {
        
        playerAnimator.SetBool("isMoving", false);
        playerAnimator.SetBool("isMovingLeft", false);
        playerAnimator.SetBool("isMovingRight", false);
        playerAnimator.SetBool("isMovingBack", false);
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.forward * speed);
            playerAnimator.SetBool("isMoving", true);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddRelativeForce(Vector3.left * speed);
            playerAnimator.SetBool("isMovingLeft", true);

        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddRelativeForce(Vector3.right * speed);
            playerAnimator.SetBool("isMovingRight", true);
        }



        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(Vector3.back * speed);
            playerAnimator.SetBool("isMovingBack", true);
        }

        if (Input.GetMouseButton(0))
        {
            ShootFX.SetActive(true);
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
        
        



        
    }
    

