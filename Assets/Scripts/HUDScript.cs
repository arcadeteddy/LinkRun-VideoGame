using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

	float playerScore = 0;

	public void IncreaseScore (int amount) {
		playerScore += amount;
	}

	void OnDisable () {
		PlayerPrefs.SetInt ("Score", (int)(playerScore * 100));
	}

	void Update () {
		playerScore += Time.deltaTime;
		GetComponent<TextMesh>().text = "SCORE: "+((int)(playerScore * 100));
	}
}
