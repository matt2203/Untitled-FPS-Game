using System;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    public GameObject ST1;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ST1")
        {
            ST1.SetActive(false);
        }
    }
}
