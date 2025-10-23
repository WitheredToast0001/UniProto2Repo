using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float moveSpeed = 10.0f;
    public float xRange = 10;
    public GameObject projectilePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space has been pressed");
            // Launch projectile
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        // Keep player inbounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // Get Input L/R
        horizontalInput = Input.GetAxisRaw("Horizontal");  
        // Move Player by input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * moveSpeed);

    }
}
