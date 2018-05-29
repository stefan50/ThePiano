using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToggleSetter : MonoBehaviour {

	void Start () {
		GetComponent<Toggle>().isOn = Screen.fullScreen;
	}
}
