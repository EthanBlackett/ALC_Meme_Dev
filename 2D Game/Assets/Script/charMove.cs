using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charMove : MonoBehaviour {

    //Player Movement variables
    public int MoveSpeed;
    public float JumpHeight;
    public float hSpeed;
    public int fric;
    public int maxS;

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
            hSpeed += MoveSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            hSpeed -= MoveSpeed;
        }
        if (hSpeed != 0)
        {
            if (hSpeed >= fric)
            {
                hSpeed -= fric;
            }
            if (hSpeed <= -fric)
            {
                hSpeed += fric;
            }
            if (Mathf.Abs(hSpeed) < fric)
            {
                hSpeed = 0;
            }
        }
        if (hSpeed > maxS)
        {
            hSpeed = maxS;
        }
        if (hSpeed < -maxS)
        {
            hSpeed = -maxS;
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(hSpeed, GetComponent<Rigidbody2D>().velocity.y);
	}
    public void Jump () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,  JumpHeight);
    }
}

