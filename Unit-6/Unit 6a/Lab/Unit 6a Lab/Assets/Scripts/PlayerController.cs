using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //define variables
    public float speed;
    private float horizontalInput;
    private float xRange = 10;
    public bool hasPowerup;
    public bool gameIsActive;
    public float ShieldTimer;
    //defines object variables
    public Transform blaster;
    public GameObject lazer;
    public GameObject shield;
    public ParticleSystem explosion;
    public ParticleSystem pop;

    private SpawnManager spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        //sets values and gets script
        gameIsActive = true;
        hasPowerup = false;
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameIsActive) //Player ony moves if game isn't over
        {
            horizontalInput = Input.GetAxis("Horizontal"); //gets the players input
            transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime); //moves the player side to side based on input

            if (transform.position.x < -xRange)
            {
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); //keeps the player from leaving a certain range
            }

            if (transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z); //keeps the player from leaving a certain range
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(lazer, blaster.transform.position, lazer.transform.rotation); //if the player presses the spacebar fire a lazer
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy")) //if the player collides with an enemy explode and set the game to inactive
        {
            explosion.Play();
            gameIsActive = false;
            Debug.Log("Game Over!");
        }
        if (other.gameObject.CompareTag("Powerup")) //if the player collides with a powerup activate the shield and destroy the power up
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            pop.Play();
            shield.SetActive(true);
            StartCoroutine(PowerupCountdown());
        }
    }

    IEnumerator PowerupCountdown() //limits the time the powerup is active
    {
        yield return new WaitForSeconds(ShieldTimer);
        shield.SetActive(false);
    }
}
