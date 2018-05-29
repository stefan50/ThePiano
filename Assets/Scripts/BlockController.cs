using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour {

	void OnTriggerStay2D(Collider2D other)
	{
		if(Input.GetKeyDown("space"))
		{
			Debug.Log("was pressed");
			Destroy(gameObject);
		}
	}
}
