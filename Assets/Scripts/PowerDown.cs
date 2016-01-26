using UnityEngine;
using System.Collections;

public class PowerDown : MonoBehaviour {
	
	HUDScript hud;
	
	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			hud = GameObject.Find("Score Text").GetComponent<HUDScript>();
			hud.IncreaseScore (-2);
			Destroy (this.gameObject);
		}
	}
}