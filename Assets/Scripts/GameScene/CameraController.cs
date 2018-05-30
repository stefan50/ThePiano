﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject target;
    private Vector3 targetPosition;
    public float speed;
	private static bool doesExist;
	
    void Start ()
    {
		if(!doesExist)
		{
			doesExist = true;
			DontDestroyOnLoad(transform.gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}
	
	
	void FixedUpdate ()
    {
        targetPosition = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime); //for different fps
	}
}
