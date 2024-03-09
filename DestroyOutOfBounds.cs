using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowBound = -10;
    private float horizontalBound = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    
    {
        // Destroys gameObject outside of set boundary
        if (transform.position.z > topBound || transform.position.z < lowBound || transform.position.x < -horizontalBound || transform.position.x > horizontalBound)
        {
            Destroy(gameObject);
        }else if (transform.position.z < lowBound)
        {
            Debug.Log("GameOver!");
            Destroy(gameObject);
        }
    }
}
