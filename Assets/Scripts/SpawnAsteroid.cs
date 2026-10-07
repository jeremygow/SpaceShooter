using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroid : MonoBehaviour
{
    public GameObject asteroid;
    protected List<GameObject> spawnPoints;

    public float spawnDelay = 0.2f;
    public float waveDelay = 3f;
    public int waveSize = 30;
    protected int waveCount;

    void Start()
    {
        spawnPoints = new List<GameObject>();

        foreach (Transform child in gameObject.transform)
        {
            spawnPoints.Add(child.gameObject);
        }

        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        while (true)
        {
            // Start wave
            waveCount = 0;
            while (waveCount < waveSize)
            {
                Spawn();
                waveCount++;
                yield return new WaitForSeconds(spawnDelay);
            }
            yield return new WaitForSeconds(waveDelay);
        }
    }

    void Spawn()
    {
        int i = Random.Range(0, spawnPoints.Count);
        GameObject spawn = spawnPoints[i];
        Instantiate(asteroid, spawn.transform);
        Debug.Log("Spawn " + i);
    }
}
