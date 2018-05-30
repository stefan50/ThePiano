using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickMove : MonoBehaviour {

    public float moveSpeed;
	private Rigidbody2D myRig;
	
	void Start ()
	{
		switch(Random.Range(0,7))
		{
			case 0: transform.position = new Vector2(357.5f, 404f); break;
			case 1: transform.position = new Vector2(410.38f, 404f); break;
			case 2: transform.position = new Vector2(463.08f, 404f); break;
			case 3: transform.position = new Vector2(515.78f, 404f); break;
			case 4: transform.position = new Vector2(568.88f, 404f); break;
			case 5: transform.position = new Vector2(621.48f, 404f); break;
			case 6: transform.position = new Vector2(674.38f, 404f); break;
			default : new Vector2(0f, 0f); break;
		}
		myRig = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
		 myRig.velocity = new Vector2(0f, -5f * moveSpeed);
	}
	
	void OnTriggerStay2D(Collider2D other)
	{
		//moveSpeed = -moveSpeed;
		
	}
}
