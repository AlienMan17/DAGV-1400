using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //define variables
    private float powerupChance;
    public int scoreToAdd;
    //defines objects
    public GameObject powerup;
    private ScoreManager scoreManager;
    private GameManager gameManager;
    //defines scripts
    private PlayerController playerController;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();//gets the GameManager
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();//gets the ScoreManager script
    }
    void Update()
    {
        if (transform.position.z < -8) //if the enemy passes the player
        {
            gameManager.isGameOver = true;//sets game over
            Debug.Log("Game Over!");
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Lazer")) //checks if the object entering the collider is a lazer
        {
            powerupChance = Random.Range(1, 11); //gets a random int
            Destroy(other.gameObject); //destroys the lazer
            Destroy(gameObject); //destroys the UFO
            scoreManager.IncreaseScore(scoreToAdd, true);//adds to the score value based on the enemy killed, and tells the scoreManager this is an enemy
            if (powerupChance == 10) //uses a random int to determine wether or not to spawn a powerup on death
            {
                Instantiate(powerup, transform.position, powerup.transform.rotation); // instantiates a powerup
            }
        }
        else if(other.gameObject.CompareTag("Shield"))//if it hits the sheild
        {
            Destroy(gameObject); //Destroy this object
            scoreManager.IncreaseScore(scoreToAdd, true);//adds to the score value based on the enemy blocked, and tells the scoreManager this is an enemy
        }
        else
        {
            Destroy(gameObject);//destroy the spaceship
        }
    }
}
