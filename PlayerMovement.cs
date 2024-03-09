using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float horizonalInput;
    public float verticalInput;
    public float speed = 15.0f;
    public float xRange = 25.0f;
    public float zRangeUp = 15.0f;
    public float zRangeDown = 1.0f;
    public GameObject projectilePrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //Limits the range of player movement to xRange in X axis
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //Limits the range of player movement to xRange in Y axis
        if (transform.position.z < -zRangeDown)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRangeDown);
        }
        if (transform.position.z > zRangeUp)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeUp);
        }

        horizonalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizonalInput * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed);
        
    //Fires gameObject on downward spacebar press
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
