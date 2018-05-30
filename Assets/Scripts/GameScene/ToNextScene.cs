using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToNextScene : MonoBehaviour {

	public string sceneName;
	private Text message;
	public string exitPoint;
	
	private PlayerMove Mc;
	
	void Start()
	{
		Mc = FindObjectOfType<PlayerMove>();
		message = GameObject.FindWithTag("PopUp").GetComponent<Text>();
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(Mc.hasKey)
		{
			SceneManager.LoadScene(sceneName);
			Mc.startPoint = exitPoint;
			//Application.LoadLevel(sceneName);
		}
		else
		{
			StartCoroutine(ShowMessage("You don't have the key", 3));
		}
	}
	
	IEnumerator ShowMessage (string text, float delay)
	{
		message.text = text;
		yield return new WaitForSeconds(delay);
		message.text = "";
	}
}
