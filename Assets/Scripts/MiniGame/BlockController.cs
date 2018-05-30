using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour {

	public string keyToPress;
	private GameObject brick;
	private bool isPressed;
	private int score;

	void Update()
	{
		if(Input.GetKeyDown(keyToPress))
		{
			GetComponent<AudioSource>().Play();
		}
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		isPressed = false;
		brick = GameObject.FindWithTag("PianoBrick");
		score = GameObject.FindWithTag("Piano").GetComponent<ScoreController>().score;
	}
	
	void OnTriggerStay2D(Collider2D other)
	{
		if(Input.GetKeyDown(keyToPress))
		{
			isPressed = true;
			if(score < 5 && score > -5)
			{
				GameObject.FindWithTag("Piano").GetComponent<ScoreController>().score++;
				Instantiate(brick);
				Destroy(brick);
			}
		}
	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		if(!isPressed)
		{
			if(score < 5 && score > -5)
			{
				GameObject.FindWithTag("Piano").GetComponent<ScoreController>().score--;
				Instantiate(brick);
				Destroy(brick);
			}
		}
	}
}
