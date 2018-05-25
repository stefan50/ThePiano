using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour {

	public void MusicToggle(bool ison) {
		switch(ison){
			case true:
		   		GetComponent<AudioSource>().Play();
		   		break;
		 
		 	case false:
		   		GetComponent<AudioSource>().Stop();
		   		break;
		}
	}

	public void MusicVolume(float slidval) {
		GetComponent<AudioSource>().volume = slidval;
	}

	public void QuitOptions(){
		SceneManager.LoadScene("TestMain");
	}
	
	public void FullScreen(bool full) {
		Screen.fullScreen = full;
	}
	
	public void ScreenSize(int cases) {
		switch(cases){
			case 0:
				Screen.SetResolution(800,600,Screen.fullScreen);
				break;
			case 1:
				Screen.SetResolution(1280,720,Screen.fullScreen);
				break;
			case 2:
				Screen.SetResolution(1920,1080,Screen.fullScreen);
				break;
		}
	}

}
