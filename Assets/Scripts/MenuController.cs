using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	public void StartGame(){
		SceneManager.LoadScene("first");
	} 

	public void Options(){
		SceneManager.LoadScene("TestOptions");
	} 

	public void QuitGame() {
		Application.Quit();
	}
}
