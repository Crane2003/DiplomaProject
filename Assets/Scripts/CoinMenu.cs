using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject CoinMenuUI;
    public void ResumeBut()
    {
        CoinMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
}
