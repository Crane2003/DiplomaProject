using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
	private GameObject playerP;
	public AudioClip audioClip;
	private AudioSource audioCoin;

	public static int k = 0;

	public static bool GameIsPaused = false;
	public GameObject CoinMenuUI;

	public void Start()
    {
		playerP = GameObject.FindGameObjectWithTag("Player");
		audioCoin = playerP.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			audioCoin.PlayOneShot(audioClip);
			CoinMenuUI.SetActive(true);
			k++;
			Time.timeScale = 0f;
			GameIsPaused = true;
			Destroy(gameObject);
		}
	}
}
