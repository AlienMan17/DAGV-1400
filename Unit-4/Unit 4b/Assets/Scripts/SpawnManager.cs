using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //variables for spawing animals
    public GameObject[] animalPrefabs;
    private float xbounds = 20;
    private float zSpawn = 20;
    //variables for activating the function
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnAnimal", startDelay, spawnInterval);
    }
    // Function that spawns random animals at a random position
    void SpawnAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-xbounds, xbounds), 0, zSpawn);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
      
    }


}
