using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour {

    //movement variables
    public float moveSpeed;

    public bool MoveRight;

    //wall check

    public Transform WallCheck;

    public float WallCheckRadius;

    public LayerMask WhatIsWall;

    public bool HittingWall;
    //Edge check

    private bool NotAtEdge;

    public Transform EdgeCheck;

    //health stuff
    public int enemyhp;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        NotAtEdge = Physics2D.OverlapCircle(EdgeCheck.position, WallCheckRadius, WhatIsWall);

        HittingWall = Physics2D.OverlapCircle(WallCheck.position, WallCheckRadius, WhatIsWall);

        if(HittingWall || !NotAtEdge) {
            MoveRight = !MoveRight;
        }

        if (MoveRight) {
            transform.localScale = new Vector3(-0.27f, 0.27f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else {
            transform.localScale = new Vector3(0.27f, 0.27f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (enemyhp <= 0 ) {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "projectile")
        {
            enemyhp -= 1;
            Destroy(other.GetComponent<GameObject>());
        }
	}

}