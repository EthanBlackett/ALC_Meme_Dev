using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileFire : MonoBehaviour
{
    public GameObject Projectile;
    public Transform FirePoint;
   
        public float Speed;

        public Rigidbody2D PC;

        public GameObject EnemyDeath;

        public GameObject ProjectileParticle;

        public int PointsForKill;

    // Use this for initialization
    void Start()
    {
        if (PC.transform.localScale.x < 0)
            Speed = -Speed;
    }

    // Update is called once per frame
    void Update()
    {
      
            if (Input.GetKey(KeyCode.RightControl))
            {
                Instantiate(Projectile, FirePoint.position, FirePoint.rotation);
            }
    }

	
}
