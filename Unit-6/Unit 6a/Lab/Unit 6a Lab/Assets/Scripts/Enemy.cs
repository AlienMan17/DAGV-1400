using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //define variables
    private float powerupChance;
    public GameObject powerup;
    private PlayerController playerController;
    // Update is called once per frame

    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();//gets the playercontroller scripts
    }
    void Update()
    {
        if (transform.position.z < -8)
        {
            playerController.gameIsActive = false;
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
