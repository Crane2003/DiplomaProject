using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieSpace : MonoBehaviour
{

	private AudioSource audioCoin;

	public static bool GameIsPaused = false;
	public GameObject DeathMenuUI;

	public GameObject respawn;

	public void Start()
	{
		audioCoin = GetComponent<AudioSource>();
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player" && HealthSystem.health == 1)
			{
			audioCoin.Play();
			DeathMenuUI.SetActive(true);
			Coin.k = 0;
			Time.timeScale = 0f;
			GameIsPaused = true;
		}
		else if (other.tag == "Player")
		{
			audioCoin.Play();
			other.transform.position = respawn.transform.position;
			HealthSystem.health--;
		}

	}
}
