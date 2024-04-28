using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //define variables
    private float powerupChance;
    public int scoreToAdd;
    public GameObject powerup;
    private PlayerController playerController;
    private ScoreManager scoreManager;
    private GameManager gameManager;
    // Update is called once per frame

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
            scoreManager.IncreaseScore(scoreToAdd);
            if (powerupChance == 10) //uses a random int to determine wether or not to spawn a powerup on death
            {
                Instantiate(powerup, transform.position, powerup.transform.rotation); // instantiates a powerup
            }
        }
        else //if it hits the player or the sheild
        {
            Destroy(gameObject); //Destroy this object
        }
    }
}
