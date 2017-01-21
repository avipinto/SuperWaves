using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour {

	public Spawn Spawn { get; set; }
	// Use this for initialization
	void Start () {
		Spawn = FindObjectsOfType<Spawn>()[0];
		float xp = Random.Range(-5f, 5f);
		float yp = Random.Range(-4f, 4f);
		float zp = 0;
		transform.position = new Vector3(xp, yp, zp);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter2D(Collision2D col)
	{
		//x.gameObject.tag == "Wall"
		Spawn.onDiskHitTarget();
		
	}

}
