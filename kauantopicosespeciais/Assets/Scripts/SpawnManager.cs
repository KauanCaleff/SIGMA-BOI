using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 15f;
    private float spawnPositionZ = 20f;
    public float startDelay = 0.5f;
    public float spawnInterval = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        Camera mainCamera = Camera.main;
        if (mainCamera != null)
        {
            
            float screenWidth = mainCamera.orthographicSize * mainCamera.aspect;
            spawnRangeX = screenWidth; 
        }
        InvokeRepeating("SpawnAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAnimal()
    {
        // escolhe um animal aleatoriamente
        // animalPrefabs.Length retorna o tamanho do vetor
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        // escolhe um posi  o x aleatoriamente
        Vector3 randomPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);
        Instantiate(animalPrefabs[animalIndex], randomPosition,
            animalPrefabs[animalIndex].transform.rotation);
    }
}