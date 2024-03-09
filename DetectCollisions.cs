using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private static int lives = 3;
    private static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player Lives: " + (lives));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        //Destroys GameObject on Collision
    private void OnTriggerEnter(Collider other)
    {
        if(gameObject.tag != "Food" && other.gameObject.tag == "Player" )
        {
            lives--;
            Debug.Log("Player lives: " + (lives));
            if(lives == 0)
            {
                Destroy(other.gameObject);
                Debug.Log("Game Over!!");
            }
        }
        else if(other.gameObject.tag != "Player" && other.gameObject.tag == "Animal")
        {
            ++score;
            Debug.Log("Player Score: " + (score));
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}

