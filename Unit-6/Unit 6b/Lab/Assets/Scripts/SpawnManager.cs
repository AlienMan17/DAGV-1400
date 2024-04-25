using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //defining variables
    public GameObject powerup;
    public GameObject[] enemies;
    private float spawnRate = 3.0f;
    private float startDelay = 3;
    private PlayerController playerController;
    private float xRange = 10;
    private int randomIndex;
    private Vector3 startPos = new Vector3(0, 1, 8);

    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPos; //sets position to starting position
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();//gets the playercontroller scripts
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnRate); //Starts spawning enemies
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void SpawnRandomUFO()
    {
        if (playerController.gameIsActive)//if the game is active spawn enemies
        {
            randomIndex = Random.Range(0, enemies.Length); //chooses a random int for an index value
            Instantiate(enemies[randomIndex], new Vector3(Random.Range(-xRange, xRange), transform.position.y, transform.position.z), enemies[randomIndex].transform.rotation); //instantiates a random enemy at a random x value location
        }
    }
}
