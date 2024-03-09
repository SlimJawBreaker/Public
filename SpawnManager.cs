using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float zRangeUp = 15.0f;
    private float zRangeDown = 1.0f;
    private float startDelay = 2;
    private float spawnInterval = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
    //Starts spawning animals with a start delay and interval rate
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
    //Spawns an random animal at a random postion 
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Vector3 spawnPosX = new Vector3 (26 , 0, Random.Range(zRangeUp, zRangeDown));

        Vector3 spawnPosNegX = new Vector3(-26, 0, Random.Range(zRangeUp, zRangeDown));

        Instantiate((animalPrefabs)[animalIndex], spawnPos, (animalPrefabs)[animalIndex].transform.rotation);
        //Quaternion.Euler
        Instantiate((animalPrefabs)[animalIndex], spawnPosX, (animalPrefabs)[animalIndex].transform.rotation * Quaternion.Euler(0, 90, 0));

        Instantiate((animalPrefabs)[animalIndex], spawnPosNegX, (animalPrefabs)[animalIndex].transform.rotation * Quaternion.Euler(0, -90, 0));
    }
}
