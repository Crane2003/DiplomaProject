using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
	public static int health = 2;
	public int numberOfLives;
	public Image[] lives;
	public Sprite fullLive;
	public Sprite emptyLive;


    void Start()
    {
        
    }
		
    void Update()
    {
		if(health > numberOfLives)
		{
			health=numberOfLives;
		}

        for (int i = 0; i <lives.Length; i++) 
		{
			if(i < health)
			{
				lives[i].sprite = fullLive;
			}
			else
			{
				lives[i].sprite = emptyLive;
			}

			if(i < numberOfLives)
			{
				lives[i].enabled = true;
			}
			else
			{
				lives[i].enabled = false;
			}
        }

		if(health < 1)
		{
			health = 2;
		}
    }
}
