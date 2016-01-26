using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {
	
	int score = 0;

	void Update () {
		score = PlayerPrefs.GetInt ("Score");
		GetComponent<TextMesh>().text = "SCORE: "+score;
	}
}
