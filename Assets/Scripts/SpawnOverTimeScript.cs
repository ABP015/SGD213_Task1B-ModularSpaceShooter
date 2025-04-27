using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnOverTimeScript : MonoBehaviour
{
    // Object to spawn
    [SerializeField]
    private GameObject spawnObject;

    [SerializeField]
    private List<GameObject> spawnList = new List<GameObject>();  

    // Delay between spawns
    [SerializeField]
    private float spawnDelay = 2f;

    private Renderer ourRenderer;

    // Use this for initialization
    void Start()
    {
        ourRenderer = GetComponent<Renderer>();

        // Call the given function after spawnDelay seconds, 
        // and then repeatedly call it after spawnDelay seconds.
        InvokeRepeating("Spawn", spawnDelay, spawnDelay);
    }

    void Spawn()
    {
        float x1 = transform.position.x - ourRenderer.bounds.size.x / 2;
        float x2 = transform.position.x + ourRenderer.bounds.size.x / 2;

        // Randomly pick a point within the spawn object
        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

        // Spawn the object at the 'spawnPoint' position
        GameObject newSpawn = Instantiate(spawnObject, spawnPoint, Quaternion.identity);
        spawnList.Add(newSpawn);
    }

    private void Update()
    {
        int enemiesDead = 0;
        // end level after 10 enemies are dead
        foreach (GameObject spawn in spawnList)
        {
            if (spawn == null)
            {
                enemiesDead++;
                if (enemiesDead++ > 10) 
                {
                   // advanced to next level
                }
            }
               
        }
    }
}
