using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool PauseGame = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (PauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
                
            }
        }
    }


    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        PauseGame = false;
        // cursor is disabled
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        PauseGame = true;
        //re-enables cursor while paused
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        // turns off the menuUI and resumes time for when player loads back in.
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Resume();
    }

    public void LoadLevelOne()
    {
        SceneManager.LoadScene(1);
    }

    public void LoaadLevelTwo()
    {
        SceneManager.LoadScene(2);
    }

}
