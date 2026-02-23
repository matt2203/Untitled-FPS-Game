using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGunDmg : MonoBehaviour
{
    public float Damage;
    public float BulletRange;
    private Transform PlayerCamera;
    
    private void Start()
    {
        PlayerCamera = Camera.main.transform;
    }

    
    void Update()
    {
        
    }
    public void shoot() {
        Ray gunRay = new Ray(PlayerCamera.position, PlayerCamera.forward);

        if(Physics.Raycast(gunRay, out RaycastHit hitInfo, BulletRange)) {
            if(hitInfo.collider.gameObject.TryGetComponent(out EnemyHealth Enemy)){
                Enemy.Health -= Damage;
            }
         
        }
    }
}
