using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManager : MonoBehaviour
{
    private float xBounds = 50;
    private float zBounds = 50;
    private float xRange = 0;
    private float zRange = 0;
    private float xArea = 10;
    private float zArea = 10;
    public float spawnRate = 3.0f;
    private Vector3 playerPos;
    public GameObject enemy;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 3, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position;
    }

    void SpawnEnemy()
    {
        Debug.Log("running xrange");
        xRange = XRangeValue();
        Debug.Log("running zrange");
        zRange = ZRangeValue();
        Debug.Log("Complete");
        transform.localPosition = new Vector3(Random.Range(-xRange, xRange), 0, Random.Range(-zRange, zRange));
        enemy.transform.position = transform.position;
        Instantiate(enemy, transform.position, enemy.transform.rotation);
    }


    float XRangeValue()
    {
        bool inRange = false;
        while(true)
        {
            xRange = 0;
            while (xRange >= -2 && xRange <= 2)
            {
                if (playerPos.x > xBounds)
                {
                    xRange = Random.Range(-xArea, 0);
                    inRange = true;
                }

                else if (playerPos.x < xBounds)
                {
                    xRange = Random.Range(0, xArea);
                    inRange = true;
                }

                else
                {
                    xRange = Random.Range(-xArea, xArea);
                    inRange = true;
                }
            }

            if (inRange)
            {
                return xRange;
            }
        }
    }

    float ZRangeValue()
    {
        bool inRange = false;
        while (true)
        {
            zRange = 0;
            while (zRange >= -2 && zRange <= 2)
            {
                if (playerPos.z > zBounds)
                {
                    zRange = Random.Range(-zArea, 0);
                    inRange = true;
                }

                else if (playerPos.z < zBounds)
                {
                    zRange = Random.Range(0, zArea);
                    inRange = true;
                }

                else
                {
                    zRange = Random.Range(-zArea, zArea);
                    inRange = true;
                }
            }

            if (inRange)
            {
                return zRange;
            }
        }
    }

}
