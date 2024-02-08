using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bgsound : MonoBehaviour
{
    [SerializeField] private Text Text1;
    public static bool Muted = false;
    void Start()
    {
    }

    public void Mute()
    {
        if (Muted == false)
        {
            AudioListener.volume = 0;
            Muted = true;
            Text1.text = "¬в≥мкнути звук";
        }
        else if (Muted == true)
        {
            AudioListener.volume = 1;
            Muted = false;
            Text1.text = "¬имкнути звук";
        }
    }

}
