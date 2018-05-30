using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Restart : MonoBehaviour {

	private int lives;
	
	void Start () {
		lives = 4;
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		lives --;
	}
	
	void OnTriggerStay2D(Collider2D other)
	{
		GameObject.FindWithTag("TextLives").GetComponent<Text>().text = "Lives: " + lives;	
	}
	
	void OnTriggerExid2D(Collider2D other)
	{
		GameObject.FindWithTag("TextLives").GetComponent<Text>().text = " ";	
		lives --;
	}
}
