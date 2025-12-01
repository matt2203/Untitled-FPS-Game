using UnityEngine;

public class EnemyDespawner : MonoBehaviour
{
    public float time = 360f;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= time)
        {
            Destroy(gameObject);
        }

    }
}
