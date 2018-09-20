using System.Collections;
using UnityEngine;

public class Death : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
  
        if(other.name == "PC")
        {
            Debug.Log("Player Enters Death Zone");
            Destroy(other);
        }
	}
}