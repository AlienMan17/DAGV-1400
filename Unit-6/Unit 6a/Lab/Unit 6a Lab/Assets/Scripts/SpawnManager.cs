using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject powerup;
    public float spawnRate = 5.0f;
    private PlayerController playerController;
    private float xRange = 10;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 1, 4);
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        StartCoroutine(SpawnPowerups());
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    IEnumerator SpawnPowerups()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            Instantiate(powerup, new Vector3(Random.Range(-xRange, xRange), transform.position.y, transform.position.z), powerup.transform.rotation);
        }
    }
}
