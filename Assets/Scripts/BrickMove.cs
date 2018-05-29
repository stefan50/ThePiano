using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickMove : MonoBehaviour {

    public float moveSpeed;
	private PolygonCollider2D col;
	private Collider2D col2;
	private Rigidbody2D myRig;
	
	void Start ()
	{
		col2 = GameObject.FindWithTag("PianoBlock").GetComponent<Collider2D>();
		col = GetComponent<PolygonCollider2D>();
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
