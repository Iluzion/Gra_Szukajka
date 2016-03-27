using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]

public class Kostka : MonoBehaviour {

	Rigidbody rBody;
	public float objectSpeed = 5f;

	// Use this for initialization
	void Start () {
		Debug.Log ("Funkcja Start");
		rBody = GetComponent <Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate () {
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		Debug.Log ("h: " +horizontal+ "v: " +vertical+ "time " +Time.deltaTime);
		rBody.AddForce (new Vector3(horizontal,0,vertical) * objectSpeed);
	}
}
