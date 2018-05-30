using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour {

	public string keyToPress;
	private GameObject brick;
	private bool isPressed;
	private int score;
	private int maxScore;

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
		maxScore = GameObject.FindWithTag("Piano").GetComponent<ScoreController>().maxScore;
	}
	
	void OnTriggerStay2D(Collider2D other)
	{
		if(Input.GetKeyDown("q"))
		{
			GameObject.FindWithTag("Piano").GetComponent<ScoreController>().score = -10;
		}
		else if(Input.GetKeyDown("e"))
		{
			GameObject.FindWithTag("Piano").GetComponent<ScoreController>().score = 10;
		}
		else if(Input.GetKeyDown(keyToPress))
		{
			isPressed = true;
			if(score < maxScore && score > -5)
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
			if(score < maxScore && score > -5)
			{
				GameObject.FindWithTag("Piano").GetComponent<ScoreController>().score--;
				Instantiate(brick);
				Destroy(brick);
			}
		}
	}
}
