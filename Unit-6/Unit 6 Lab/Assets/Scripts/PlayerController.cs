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
    public float ShieldTimer;
    //defines object variables
    public Transform blaster;
    public GameObject lazer;
    public GameObject shield;
    public ParticleSystem explosion;
    public ParticleSystem pop;
    public AudioClip explosionSFX;
    public AudioClip lazerBlast;
    private AudioSource playerAudio;
    //defines scripts
    private ScoreManager scoreManager;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        //sets values and gets script
        hasPowerup = false;
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameManager.isGameOver) //Player ony moves if game isn't over
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
                playerAudio.PlayOneShot(lazerBlast);//plays a sound for the lazer
                Instantiate(lazer, blaster.transform.position, lazer.transform.rotation); //if the player presses the spacebar fire a lazer
                scoreManager.DecreaseScore(1); //decreases score everytime you shoot so the player doesn't spam
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy")) //if the player collides with an enemy explode and set the game to inactive
        {
            playerAudio.PlayOneShot(explosionSFX);//plays explosion sound
            explosion.Play();//explosion particle effect
            gameManager.isGameOver = true;//sets game over
            Debug.Log("Game Over!");
        }
        if (other.gameObject.CompareTag("Powerup")) //if the player collides with a powerup activate the shield and destroy the power up
        {
            hasPowerup = true;//has powerup
            Destroy(other.gameObject);//destroys powerup
            scoreManager.IncreaseScore(20, false);//increases score, and this is not an enemy
            pop.Play();//play effect
            shield.SetActive(true);//shows shield
            StartCoroutine(PowerupCountdown());//starts powerup countdown
        }
    }

    IEnumerator PowerupCountdown() //limits the time the powerup is active
    {
        yield return new WaitForSeconds(ShieldTimer);//countsdown
        shield.SetActive(false);//hides shield
    }
}
