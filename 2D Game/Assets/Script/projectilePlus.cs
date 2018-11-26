using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectilePlus : MonoBehaviour {

    public GameObject Firepoint;

    public GameObject PC;

    public float Speed;

    public float lifetime;

	// Use this for initialization
	void Start () {
        PC = GameObject.Find("PC");
        Firepoint = GameObject.Find("Firepoint");
        Speed = Speed * Mathf.Sign(PC.transform.localScale.x) + PC.GetComponent<Rigidbody2D>().velocity.x;
        GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, 0f);
	}

	// Update is called once per frame
	void Update () {
        lifetime--;
        if (lifetime <= 0) {
            Destroy(gameObject);
        }
	}
}