using UnityEngine;
using System.Collections;

public class Ripple : MonoBehaviour
{
	public Disk[] Disks { get; set; }

	void Awake()
	{
		Disks = FindObjectsOfType<Disk>();
	}

	// Use this for initialization
	void Start()
	{
		//disk = GameObject.FindObjectOfType<Disk> ();
		//Debug.Log(disks.Length);
		MakeWaves();
		//StartCoroutine(DrawWave());
	}

	// Update is called once per frame
	void Update()
	{

	}


	void MakeWaves()
	{
		foreach (var disk in Disks)
		{
			Vector2 v = (disk.transform.position - transform.position);
			var directon = v.normalized;
			var force = 100 / v.magnitude;
			disk.Hit(directon * force);
		}
		GameObject.Destroy(this.gameObject, 0.2f);
	}

	IEnumerator DrawWave()
	{
		yield return new WaitForSeconds(0.2f);
		//for (int i = 0; i < 5; i++)
		//{
		//	this.transform.localScale *= 1.5f;
		//	yield return new WaitForSeconds(0.05f);
		//}
		Destroy(gameObject);
	}
}
