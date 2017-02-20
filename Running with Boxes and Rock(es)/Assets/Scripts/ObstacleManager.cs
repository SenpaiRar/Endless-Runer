using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour {

    public List<GameObject> listOfObstacles = new List<GameObject>();
    public List<Vector3> listOfSpawns = new List<Vector3>();
    public float timeTillSpawn; //how long it takes till each obstacle spawns
    public float timeVariation; //this determines how more time *could*be added too timeTillSpawn, adds randomness
    private float currentTimer; 
	void Start () {
        currentTimer = timeTillSpawn;       
	}
	
	
	void Update () {
        currentTimer -= 1 * Time.deltaTime;
        if(currentTimer <= 0)
        {
            currentTimer = timeTillSpawn;
            Invoke("spawnObstacle", Random.Range(0, timeVariation));
        }
	}

    void spawnObstacle()
    {
        GameObject obstacleToSpawn = listOfObstacles[Random.Range(0, listOfObstacles.Capacity)];
        if(obstacleToSpawn.tag == "Bottom")//check if the sprite should be spawned on top or on bottom of the screen
        {
            Instantiate(obstacleToSpawn, listOfSpawns[1], Quaternion.identity);
        }
        else if(obstacleToSpawn.tag == "Top")
        {
            Instantiate(obstacleToSpawn, listOfSpawns[0], Quaternion.identity);
        }

    }

    
}
