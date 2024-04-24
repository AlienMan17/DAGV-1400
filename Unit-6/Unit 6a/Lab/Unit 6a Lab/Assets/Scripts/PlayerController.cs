using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    private float horizontalInput;
    private float xRange = 10;
    public bool hasPowerup;
    public bool gameIsActive;
    public float ShieldTimer;

    public Transform blaster;
    public GameObject lazer;
    public GameObject Shield;

    private SpawnManager spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        gameIsActive = true;
        hasPowerup = false;
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(lazer, blaster.transform.position, lazer.transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Lazer"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            Shield.SetActive(true);
            StartCoroutine(PowerupCountdown());
        }
    }

    IEnumerator PowerupCountdown()
    {
        yield return new WaitForSeconds(ShieldTimer);
        Shield.SetActive(false);
    }
}
