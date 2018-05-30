using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionController : MonoBehaviour {

	public string sceneName;
	
	public string exitPoint;
	
	private PlayerMove Mc;
	
	void Start()
	{
		Mc = FindObjectOfType<PlayerMove>();
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		SceneManager.LoadScene(sceneName);
		Mc.startPoint = exitPoint;
		//Application.LoadLevel(sceneName);
	}
}
