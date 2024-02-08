using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject DeathMenuUI;
  
    public void ResumeBut()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        DeathMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

}
