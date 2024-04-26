using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuController : MonoBehaviour
{
    public CanvasGroup OptionalPanel;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Back()
    {
        OptionalPanel.alpha = 0;
        OptionalPanel.blocksRaycasts = false;
    }

    public void Levels()
    {
        OptionalPanel.alpha = 1;
        OptionalPanel.blocksRaycasts = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
