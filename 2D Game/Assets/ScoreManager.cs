using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int score;

    Text Scoretext;

	// Use this for initialization
	void Start () {
        Scoretext = GetComponent<Text>();

        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (score < 0)
            score = 0;

        Scoretext.text = " " + score;
	}

    public static void AddPoints (int pointstoadd) {
        score += pointstoadd;

    }

    public static void Reset() {

        score = 0;
    }
}
