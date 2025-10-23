using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float fireCooldown = 1.0f;

    void Start()
    {
        StartCoroutine(SpawnDog());
    }
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        //if (Input.GetKeyDown(KeyCode.Space))
        {
           // if (canSpawn)
            {
            //    Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }
    }
    IEnumerator SpawnDog()
    {
        while (true)
        {
            bool canSpawn = true;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (canSpawn == true)    
                {
                    Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                    bool CanSpawn = false; 
                    
                }
            }
            yield return new WaitForSeconds(fireCooldown);

        }
    }
}
