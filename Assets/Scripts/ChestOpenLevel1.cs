using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestOpenLevel1 : MonoBehaviour
{
	Animator ChestAnim;
	private GameObject playerP;
	public AudioClip audioClip;
	private AudioSource audioCoin;

	void Start()
	{
		Coin.k = 0;
		ChestAnim = GetComponent<Animator>();
		playerP = GameObject.FindGameObjectWithTag("Player");
		audioCoin = playerP.GetComponent<AudioSource>();
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player" && Coin.k == 1)
		{
			audioCoin.PlayOneShot(audioClip);
			ChestAnim.SetBool("IsOpen", true);
		}
		if (Coin.k == 1)
			StartCoroutine(ExampleCoroutine());
	}
	IEnumerator ExampleCoroutine()
	{
		yield return new WaitForSeconds(1.5f);
		SceneManager.LoadScene("menu");
	}
}