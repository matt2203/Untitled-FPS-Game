using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float speed = 4700;
    public Rigidbody rb;
    public GameObject TransitionPlayer;
   
    
 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void OnTriggerEnter(Collider other)
    {
        if (tag == "PlayerLvl2")
        {
            gameObject.SetActive(false);
            TransitionPlayer.SetActive(true);
        }
    }

    void FixedUpdate()
    {
        {
            rb.AddRelativeForce(Vector3.forward * speed);
        }
    }

     
        
}       
    