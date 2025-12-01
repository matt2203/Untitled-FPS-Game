using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATSpawnManager : MonoBehaviour
{
    [Header("Prefab to Spawn")]
    public GameObject prefabToSpawn;

    [Header("Cube Space Dimensions")]
    public Vector3 cubeCenter = Vector3.zero;
    public Vector3 cubeSize = new Vector3(10, 10, 10);

    [Header("Spawn Settings")]
    public int numberOfSpawns = 10;
    public float startDelay;
    public float spawnInterval;

    void Start()
    {
        InvokeRepeating("SpawnObjects", startDelay, spawnInterval);

    }

    void SpawnObjects()
    {
        for (int i = 0; i < numberOfSpawns; i++)
        {
            Vector3 randomPosition = GetRandomPositionInCube();
            Instantiate(prefabToSpawn, randomPosition, Quaternion.identity);
        }
    }

    Vector3 GetRandomPositionInCube()
    {
        return new Vector3(
            Random.Range(cubeCenter.x - cubeSize.x / 2, cubeCenter.x + cubeSize.x / 2),
            Random.Range(cubeCenter.y - cubeSize.y / 2, cubeCenter.y + cubeSize.y / 2),
            Random.Range(cubeCenter.z - cubeSize.z / 2, cubeCenter.z + cubeSize.z / 2)
        );
    }
    
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(cubeCenter, cubeSize);
    }
}    

    


