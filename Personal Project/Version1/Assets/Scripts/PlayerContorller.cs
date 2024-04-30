using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorller : MonoBehaviour
{

    private float speed = 10;
    private Rigidbody playerRb;
    float horizontalInput;
    float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate((horizontalInput * speed * Time.deltaTime), 0, (verticalInput * speed * Time.deltaTime));
    }
}
