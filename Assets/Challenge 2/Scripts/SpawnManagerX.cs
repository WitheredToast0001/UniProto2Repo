using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;


    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        StartCoroutine (SpawnRandomBall());
    }

    // Spawn random ball at random x position at top of play area
    IEnumerator SpawnRandomBall ()
    {
       while (true)
        {
            // Generate random ball index and random spawn position
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
            //random spawn time
            float spawnInterval = Random.Range(3, 5);
            //select a ball
            int randomBall = Random.Range(0, ballPrefabs.Length);
            // instantiate ball at random spawn location
            Instantiate(ballPrefabs[randomBall], spawnPos, ballPrefabs[randomBall].transform.rotation);
            Debug.Log("Ball Has Spawned");
            yield return new WaitForSeconds(spawnInterval);

        }
    }
     
}
