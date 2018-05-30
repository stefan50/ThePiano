using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float moveSpeed;
    private Animator ani;
    private bool isMoving;
    private Vector2 lastMove;
	private Rigidbody2D myRig;
	private static bool doesExist; 
	
	public string startPoint;
	
	void Start ()
    {
        ani = GetComponent<Animator>();
		myRig = GetComponent<Rigidbody2D>();
		
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
	
	void Update ()
    {
        isMoving = false;
		if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f )
        {
            //transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            myRig.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, 0f);
			isMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }
        else if(Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            //transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            myRig.velocity = new Vector2(0f, Input.GetAxisRaw("Vertical") * moveSpeed);
			isMoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
        }
		
		if(Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f )
		{
			myRig.velocity = new Vector2(0f, myRig.velocity.y);
		}
		
		if(Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f )
		{
			myRig.velocity = new Vector2(myRig.velocity.x, 0f);
		}
        ani.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        ani.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        ani.SetBool("IsMoving", isMoving);
        ani.SetFloat("LastMoveX", lastMove.x);
        ani.SetFloat("LastMoveY", lastMove.y);
	}
}
