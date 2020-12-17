using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public void MainMenu()
    {
        //Loads Main Menu
        SceneManager.LoadScene("MainMenu");
    }

    public void Retry()
    {
        //Loads First scene
        SceneManager.LoadScene("CityStreets");
    }
}
