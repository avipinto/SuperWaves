using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject Wave;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			//Debug.Log (Input.mousePosition);
			var wave = Instantiate (Wave);
			wave.transform.position = Camera.main.ScreenToWorldPoint (Input.mousePosition) + new Vector3(0,0,10);
			wave.transform.localScale = Vector3.one;
		}
	}
}
