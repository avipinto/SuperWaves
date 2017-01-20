using UnityEngine;
using System.Collections;

public class Disk : MonoBehaviour {

	Rigidbody2D body;

	// Use this for initialization
	void Awake () {
		//Vector3 direction = transform.position - Vector3.left * 5;
		body = GetComponent<Rigidbody2D> ();

		//body.AddForceAtPosition (direction.normalized, transform.position);
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void Hit(Vector2 force) {
		body.AddForce (force);
	}
}
