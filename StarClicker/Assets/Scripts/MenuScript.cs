using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MainGame");
    }
    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void PlayGameFromInstructions()
    {
        SceneManager.LoadScene("MainGame");
    }
    public void GameOvertoMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
