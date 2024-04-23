using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene(2);
    }

    public void LevelOne()
    {
        SceneManager.LoadScene(1);
    }

    public void LevelTwo()
    {
        SceneManager.LoadScene(2);
    }
}
