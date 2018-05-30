using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStart : MonoBehaviour {

	private PlayerMove Mc;
	private CameraController Cam;

	public string pointName;

	void Start () {
		Mc = FindObjectOfType<PlayerMove>();
		
		if(Mc.startPoint == pointName)
		{
			Mc.transform.position = transform.position;
		
			Cam = FindObjectOfType<CameraController>();
			Cam.transform.position = new Vector3(transform.position.x, transform.position.y, Cam.transform.position.z);
		}
	}
}
