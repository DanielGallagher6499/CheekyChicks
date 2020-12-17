using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryBuildings : MonoBehaviour
{
    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player"); // Finds the player
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerCollision.playerState())
        {
            //When the player is over 250 away destroy this game object. 
            if ((player.transform.position.z - transform.position.z) > 250)
            {
                Destroy(gameObject);
            }
        }   
    }
}
