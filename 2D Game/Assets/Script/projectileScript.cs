using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooty : MonoBehaviour
{

    public Transform FirePoint;
    public GameObject Projectile;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightControl))
        {
            Instantiate(Projectile, FirePoint.position, FirePoint.rotation);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            GameObject tempDie = other.GetComponent<GameObject>();
            GameObject.Destroy(tempDie);
        }
    }

}