using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileScript : MonoBehaviour
{

    public Transform FirePoint;
    public GameObject Projectile;

    // Update is called once per frame


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            GameObject tempDie = other.GetComponent<GameObject>();
            Object.Destroy(other);
        }
    }
}
