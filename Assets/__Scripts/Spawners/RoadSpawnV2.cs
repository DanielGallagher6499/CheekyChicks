using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawnV2 : MonoBehaviour
{
    public GameObject[] RoadPrefabs;
    public GameObject[] CountryPrefabs;
    public GameObject[] CityPrefabs;
    public GameManager gameManager;
    public Transform playerTransform;
    public int score;
    public float zSpawn = 0;
    public float roadLength = 70f;
    public int numberOfRoad = 5;


    //Spawns our roads depending on the player's score

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        score = gameManager.score;
        for (int i = 0; i < numberOfRoad; i++)
        {
            if (i == 0)
                SpawnRoad(0);
            else
            {
                SpawnRoad(Random.Range(0, RoadPrefabs.Length));
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        score = gameManager.score;

        if (PlayerCollision.playerState())
        {
            if (playerTransform.position.z > zSpawn - (numberOfRoad * roadLength))
            {
                SpawnRoad(Random.Range(0, RoadPrefabs.Length));
            }
        }

        SwitchTiles();
    }

    //Spawn road message
    public void SpawnRoad(int roadIndex)
    {
        Instantiate(RoadPrefabs[roadIndex], transform.forward * zSpawn, new Quaternion(0, 90, 0, 90));
        zSpawn += roadLength;
    }


    //Switches the tiles that are spawning
    public void SwitchTiles()
    {
        if(score < 100)
        {
            RoadPrefabs = CityPrefabs;
        }
        else if (score > 100)
        {
            RoadPrefabs = CountryPrefabs;
        }

    }
}
