using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour {

	private PlayerMove Mc;

	void Start () {
		Mc = FindObjectOfType<PlayerMove>();
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		Mc.hasKey = true;
		Destroy(gameObject);
	}
}
