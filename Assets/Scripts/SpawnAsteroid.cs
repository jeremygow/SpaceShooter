using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroid : MonoBehaviour
{
    public GameObject asteroid;
    protected List<GameObject> spawnPoints;

    void Start()
    {
        foreach (Transform child in gameObject.transform)
        {
            GameObject spawn = child.gameObject;
            Instantiate(asteroid, spawn.transform);
        }
    }

    void Update()
    {
        
    }
}
