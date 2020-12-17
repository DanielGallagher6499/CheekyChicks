using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    private static bool playerAlive = true;
    [SerializeField] public GameObject endGameUi;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            //Kills the player and loads the death menu
            playerAlive = false;
            Destroy(gameObject);
            endGameUi.SetActive(true);
        }
    }

    public static bool playerState()
    {
        //Returns the player state
        return playerAlive;
    }

    public static void setPlayerState(bool state)
    {
        playerAlive = state;
    }
}
