using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float fireCooldown = 1.0f;
    public bool canSpawn = true;

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
            if (Input.GetKeyDown(KeyCode.Space) && canSpawn)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                bool canSpawn = false;

            }
            yield return new WaitForSeconds(fireCooldown);

        }
    }
    IEnumerator SpawnADog()
    {
        while (true)
        {

        }
    }
}
