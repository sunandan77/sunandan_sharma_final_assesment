using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public Transform player;
    public float maxTime;
    public float minTime;
    public int valuespawn = 2;
    public GameObject[] spawnPrefabs;
    public Transform[] spawnLocation;
    int currentPrefabs;
    int currentLocation;
    void Start()
    {
        spawner();
    }

    void Update()
    {
        if (player.transform.position.x > 40)
            CancelInvoke();
    }

    void spawner()
    {
        List<Transform> spawnPoint = new List<Transform>(spawnLocation);
        for (int i = 0; i < valuespawn; i++)
        {

            if (spawnPoint.Count <= 0)
                return;
            currentPrefabs = Random.Range(0, spawnPrefabs.Length);
            currentLocation = Random.Range(0, spawnPoint.Count);
            Transform pos = spawnPoint[currentLocation];
            spawnPoint.RemoveAt(currentLocation);
            Instantiate(spawnPrefabs[currentPrefabs], pos.position, pos.rotation);
            Invoke("spawner", Random.Range(minTime, maxTime));
        }

    }

}
