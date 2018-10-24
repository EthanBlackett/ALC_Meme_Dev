using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalParticle : MonoBehaviour
{
    public GameObject goalParticleSystem;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ball") {
            Instantiate (goalParticleSystem,transform);

        }
    }

}
