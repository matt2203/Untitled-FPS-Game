using UnityEngine;

public class DSController2 : MonoBehaviour
{
    public GameObject Dropship;
    public GameObject Hole;

    
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length <= 0)
        {
            Hole.SetActive(true);
            Dropship.SetActive(true);
        }

    }
}
