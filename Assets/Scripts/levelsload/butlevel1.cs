using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class butlevel1 : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("1");
    }
}