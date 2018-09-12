using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charMove : MonoBehaviour {

    //Player Movement variables
    public int MoveSpeed;
    public float JumpHeight;

    //Player grounded variables
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

	// Use this for initialization
	void Start () {
		
	}


	void FixedUpdate()
	{
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
	}

	// Update is called once per frame
	void Update () {
		//This code makes the character jump
        if(Input.GetKeyDown (KeyCode.Space)&& grounded) {
            Jump();
        }
        if(Input.GetKey (KeyCode.D)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

	}
    public void Jump () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,  JumpHeight);
    }
}

