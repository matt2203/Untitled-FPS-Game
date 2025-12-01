using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSensitivity = 150f; 
    public float verticalClampUp = 60f;
    public float verticalClampDown = 20;
    private float xRotation;
    public GameObject player;
    
    
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

   
    void Update()
    {
        
         float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; 
         float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; 
         xRotation -= mouseY;
         xRotation = Mathf.Clamp(xRotation, -verticalClampUp, verticalClampDown);
         

         transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
         player.transform.Rotate(Vector3.up * mouseX);
    }
}
