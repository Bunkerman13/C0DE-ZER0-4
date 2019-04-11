using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        if (GameObject.Find("ScoreTransfer(Clone)") != null)
            Destroy(GameObject.Find("ScoreTransfer(Clone)"));

        SceneManager.LoadScene("MainGame");
    }
    public void Instructions()
    {
        if (GameObject.Find("ScoreTransfer(Clone)") != null)
            Destroy(GameObject.Find("ScoreTransfer(Clone)"));

        SceneManager.LoadScene("Instructions");
    }
    public void MainMenu()
    {
        if (GameObject.Find("ScoreTransfer(Clone)") != null)
            Destroy(GameObject.Find("ScoreTransfer(Clone)"));

        SceneManager.LoadScene("MainMenu");
    }
    public void PlayGameFromInstructions()
    {
        if (GameObject.Find("ScoreTransfer(Clone)") != null)
            Destroy(GameObject.Find("ScoreTransfer(Clone)"));

        SceneManager.LoadScene("MainGame");
    }
    public void GameOvertoMainMenu()
    {

        if (GameObject.Find("ScoreTransfer(Clone)") != null)
            Destroy(GameObject.Find("ScoreTransfer(Clone)"));

        SceneManager.LoadScene("MainMenu");
    }
}
