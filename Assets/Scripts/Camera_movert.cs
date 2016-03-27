using UnityEngine;
using System.Collections;

public class Camera_movert : MonoBehaviour {

	public GameObject Player;
	private Vector3 offset;

	void Start () {
		transform.position = Player.transform.position;
	}

	void LateUpdate () {
		transform.position = Player.transform.position + offset;
	}
}
