using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //defining variables
    private float spawnRate = 1.5f;
    private float startDelay = 3;
    private float xRange = 10;
    private int randomIndex;
    private Vector3 startPos = new Vector3(0, 1, 8);
    //defining gameobjects
    public GameObject powerup;
    public GameObject[] enemies;
    //define scripts
    private GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPos; //sets position to starting position
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();//gets the game manager script
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnRate); //Starts spawning enemies
    }

    void SpawnRandomUFO()
    {
        if (!gameManager.isGameOver)//if the game is active spawn enemies
        {
            randomIndex = Random.Range(0, enemies.Length); //chooses a random int for an index value
            Instantiate(enemies[randomIndex], new Vector3(Random.Range(-xRange, xRange), transform.position.y, transform.position.z), enemies[randomIndex].transform.rotation); //instantiates a random enemy at a random x value location
        }
    }
}
