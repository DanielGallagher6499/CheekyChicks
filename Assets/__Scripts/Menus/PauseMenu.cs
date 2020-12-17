using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public KeyCode pauseKey;
    public static bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false); //On start Menu is not active
    }

    // Update is called once per frame
    void Update()
    {
        //If ESC is pressed 
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    //Pause Game Method
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f; // Stops animations and updates
        isPaused = true;
    }

    //Resume Game
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f; // Resumes animations and updates
        isPaused = false;
    }

    //Main Menu
    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    
    //Quit
    public void QuitGame()
    {
        Debug.Log("Game Quit Successfully!");
        Application.Quit();
    }

}
