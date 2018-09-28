using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour {

    public GameObject currentCheckPoint;

    private Rigidbody2D PC;

    // particles
    public GameObject deathParticle;

    public GameObject respawnParticle;

    // Respawn Delay

    public float respawnDelay;

    // Point penalty on death
    public int PointPenaltyOnDeath;

    // Store gravity value
    private float gravityStore;



	// Use this for initialization
	void Start () {
        PC = FindObjectOfType<Rigidbody2D>();
	}

    public void RespawnPlayer() {
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo() {
        // Generate death particle
        Instantiate(deathParticle, PC.transform.position, PC.);
        // Hide Player
        PC.enabled = false;
        PC.GetComponent<Renderer>().enabled = false;
    }

	// Update is called once per frame
	void Update () {
		
	}
}
