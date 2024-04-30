using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float xBounds = 50;
    private float zBounds = 50;
    private float xRange;
    private float zRange;
    private float xArea = 10;
    private float zArea = 10;
    public float spawnRate = 3.0f;
    public GameObject enemy;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        zRange = player.transform.localPosition.z + Random.Range(-zArea, zArea);
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            xRange = XRangeValue();
            zRange = ZRangeValue();
            transform.position = new Vector3(Random.Range(-xRange, xRange), 0, Random.Range(-zRange, zRange));
            enemy.transform.position = transform.position;
            yield return new WaitForSeconds(spawnRate);
            Instantiate(enemy, transform.position, enemy.transform.rotation);
        }
    }

    float XRangeValue()
    {
        bool inRange = false;
        while(!inRange)
        {
            xRange = player.transform.localPosition.x + Random.Range(-xArea, xArea);
            if (!(xRange < -xBounds) && !(xRange > xBounds))
            {
                inRange = true;
                return xRange;
            }
        }
        return 0;
    }

    float ZRangeValue()
    {
        bool inRange = false;
        while (!inRange)
        {
            zRange = player.transform.localPosition.z + Random.Range(-xArea, xArea);
            if (!(zRange < -zBounds) && !(zRange > zBounds))
            {
                inRange = true;
                return zRange;
            }
        }
        return 0;
    }
}
