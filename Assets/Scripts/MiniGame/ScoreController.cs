using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour {
	
	public int score;
	
	void Start () {
		score = 0;
	}
	
	void Update () {
		GameObject.FindWithTag("TextScore").GetComponent<Text>().text = "Score: " + score;
		if(score == 5)
		{
			StartCoroutine(Win());
		}
		else if(score == -5)
		{
			StartCoroutine(Lose());
		}
	}
	
	IEnumerator Lose()
	{
		GameObject.FindWithTag("TextGame").GetComponent<Text>().text = "YOU LOSE";
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene("first");
	}
	
	IEnumerator Win()
	{
		GameObject.FindWithTag("TextGame").GetComponent<Text>().text = "YOU WIN";
		yield return new WaitForSeconds(3);
		Application.LoadLevel("first");
	}
}
