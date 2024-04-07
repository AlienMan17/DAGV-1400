using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorller : MonoBehaviour
{

    private float speed = 10;
    private Rigidbody playerRb;
    private float sideBounds = 40;
    private float vertBounds = 40;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //moves if inside the boundry
        if (Input.GetKey(KeyCode.W) && (transform.position.z < vertBounds))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) && (transform.position.x > -sideBounds))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) && (transform.position.z > -vertBounds))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x < sideBounds)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
