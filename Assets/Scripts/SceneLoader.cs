using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    int currentScene;

    void Start()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadSplashScreen()
    {
        SceneManager.LoadScene(0);
    }

    public void StarGame()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentScene + 1);
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene(SceneManager.sceneCount);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
