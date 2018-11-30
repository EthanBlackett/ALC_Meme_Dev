using System.Collections;
using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour
{


    public levelManager levelManager;

    // Use this for initialization
    void Start()
    {
        levelManager = FindObjectOfType<levelManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "PC")
        {
            levelManager.RespawnPlayer();
        }
    }
}