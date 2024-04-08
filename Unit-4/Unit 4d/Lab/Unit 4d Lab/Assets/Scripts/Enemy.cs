using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyrb;
    public float speed = 3.0f;
    public GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        enemyrb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyrb.AddForce((player.transform.position - transform.position).normalized * speed);
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
