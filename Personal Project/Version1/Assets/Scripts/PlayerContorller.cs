using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorller : MonoBehaviour
{
    private float xBounds = 50;
    private float zBounds = 50;
    private float speed = 10;
    private float health = 5;
    public Vector2 turn;
    private Rigidbody playerRb;
    public GameObject bullet;
    public GameObject gun;
    float horizontalInput;
    float verticalInput;
    public bool isGameActive = true;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameActive)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
            transform.Translate((horizontalInput * speed * Time.deltaTime), 0, (verticalInput * speed * Time.deltaTime));
        }

        if (Input.GetMouseButtonDown(0) && isGameActive)
        {
            Instantiate(bullet, gun.transform.position, gun.transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            health -= 1;
            if (health <= 0)
            {
                isGameActive = false;
            }
        }
    }
}
