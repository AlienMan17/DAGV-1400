using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject player;
    private float y = 20;

    // Start is called before the first frame update
    void Start()
    {
        transform.position  = Camera.main.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x != player.transform.position.x || transform.position.z != player.transform.position.z)
        {
            transform.position = new Vector3(player.transform.position.x, y, player.transform.position.z);
        }
    }
}
