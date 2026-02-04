using UnityEngine;

public class DSController2 : MonoBehaviour
{
    public GameObject Dropship;
    public GameObject Hole;
    public GameObject Exp;
    public GameObject ExpSpawn;

    
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length <= 0)
        {
            Instantiate(Exp, ExpSpawn.transform.position, ExpSpawn.transform.rotation);
            Hole.SetActive(false);
            Dropship.SetActive(true);
        }

    }
}
