using UnityEngine;

public class DSAudio : MonoBehaviour
{
    public GameObject IndicatorBeacon;
     
   
     void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {

            Destroy(gameObject);
            IndicatorBeacon.SetActive(true);

        }     }
}
