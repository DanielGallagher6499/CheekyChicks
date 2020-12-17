using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private Transform player;
    private float yOffset = 4f;
    private float zOffset = -10;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // LateUpdate is called once per frame to ensure the player has moved
    void LateUpdate()
    {
       if (PlayerCollision.playerState())
        {
            transform.position = new Vector3(player.position.x, player.position.y + yOffset, player.position.z + zOffset);
        } 
    }
}
