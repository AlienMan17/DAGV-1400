using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //define variables
    private float zRange = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if the object enters/exits this range, destroy it
        if (transform.position.z > zRange)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < -zRange)
        {
            Destroy(gameObject);
        }
    }
}
