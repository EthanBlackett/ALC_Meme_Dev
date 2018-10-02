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
        Instantiate(deathParticle, PC.transform.position, PC.transform.rotation);
        // Hide Player
        //PC.enabled = false;
        PC.GetComponent<Renderer>().enabled = false;
        //Gravity Reset
        gravityStore = PC.GetComponent<Rigidbody2D>().gravityScale;
        PC.GetComponent<Rigidbody2D>().gravityScale = 0f;
        PC.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        //point penalty
        ScoreManager.AddPoints(-PointPenaltyOnDeath);
        //Debug message
        Debug.Log("Player Respawn");
        //respawn delay
        yield return new WaitForSeconds(respawnDelay);
        //gravity restore
        PC.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
        //match players transform position
        PC.transform.position = currentCheckPoint.transform.position;
        //show player
        //PC.enabled = true;
        PC.GetComponent<Renderer>().enabled = true;
        //spawn player
        Instantiate(respawnParticle, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);

    }

	// Update is called once per frame
	void Update () {
		
	}
}
