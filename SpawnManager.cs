using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabsList;
    public int animalIndex;
    public float range = 8;
    private float spawnDelay = 1.5f;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnAnimals", spawnDelay, spawnInterval);
    }

    void Update()
    {
        
    }
    void SpawnAnimals()
    {
        Instantiate(
            animalPrefabsList[Random.Range(0, animalPrefabsList.Length)],
            new Vector3(Random.Range(-range, range), 0, 22),
            animalPrefabsList[Random.Range(0, animalPrefabsList.Length)].transform.rotation);
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
