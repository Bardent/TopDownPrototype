using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    private GameObject[] spawns;
    [SerializeField] private GameObject toSpawn;
    public float spawnDelay = 1f;
    public float lastSpawn = 0f;

    void Start () {
        spawns = GameObject.FindGameObjectsWithTag("Spawns");
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.time >= lastSpawn + spawnDelay) {
            int spawnLoc = Random.Range(0,spawns.Length);
            lastSpawn = Time.time;
            SpawnEnemy(spawnLoc);
            
        }

	}

    void SpawnEnemy(int spawnLoc) {

        
        Transform coordinates = spawns[spawnLoc].transform;
        Instantiate(toSpawn, coordinates.position, coordinates.rotation);

    }
}
