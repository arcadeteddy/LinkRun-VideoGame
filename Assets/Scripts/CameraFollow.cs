using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public float cameraPosition = 4;
	public Transform player;

	void Update () {
		transform.position = new Vector3 (player.position.x + cameraPosition, 0, -10);
	}
}
