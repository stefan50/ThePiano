using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour {

	private GameObject enemy;
	private bool hasEntered;
	
	private PlayerMove Mc;

	void Start () 
	{
		Mc = FindObjectOfType<PlayerMove>();
		enemy = GameObject.FindWithTag("Enemy");
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(!(Mc.transform.position == transform.position))
		{
			hasEntered = true;
		}
	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		if(!hasEntered)
		{
			Destroy(enemy);
		}
	}
}
