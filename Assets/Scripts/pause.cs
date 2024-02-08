using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject pauseButton;
 
    public void ResumeBut()
    {
        pauseMenuUI.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void pauseBut()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        pauseButton.SetActive(false);
        GameIsPaused = true;
    }
    public void MenuExit()
    {
        SceneManager.LoadScene("menu");
        pauseMenuUI.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

}
