using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

	public bool overFree = false;
	public bool overInfinite = false;

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			if (overFree == true) {
				Application.LoadLevel("GameOverFree");
				return;
			}
			if (overInfinite == true) {
				Application.LoadLevel("GameOverInfinite");
				return;
			}
		}

		if (other.gameObject.transform.parent) {
			Destroy (other.gameObject.transform.parent.gameObject);
		}
		else {
			Destroy (other.gameObject);
		}
	}
}
