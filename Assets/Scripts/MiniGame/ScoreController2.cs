using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController2 : MonoBehaviour {
	
	public int score;
	public int maxScore = 5;
	private PlayerMove Mc;
	
	void Start () {
		score = 0;
		Mc = FindObjectOfType<PlayerMove>();
	}
	
	void Update () {
		GameObject.FindWithTag("TextScore").GetComponent<Text>().text = "Score: " + score;
		if(score >= maxScore)
		{
			StartCoroutine(Win());
		}
		else if(score <= -5)
		{
			StartCoroutine(Lose());
		}
	}
	
	IEnumerator Lose()
	{
		GameObject.FindWithTag("TextGame").GetComponent<Text>().text = "YOU LOSE";
		Mc.startPoint = "Start";
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene("first");
	}
	
	IEnumerator Win()
	{
		GameObject.FindWithTag("TextGame").GetComponent<Text>().text = "YOU WIN";
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene("End");
	}
}
