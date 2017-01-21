using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Spawn : MonoBehaviour {

	public GameObject HitObject;
	public int TargetHitCount { get; set; }
	public Disk[] Disks { get; set; }

	// Use this for initialization
	void Start () {
		Disks = FindObjectsOfType<Disk>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			//Debug.Log (Input.mousePosition);
			var wave = Instantiate (HitObject);
			wave.transform.position = Camera.main.ScreenToWorldPoint (Input.mousePosition) + new Vector3(0,0,10);
			wave.transform.localScale = Vector3.one;
		}
	}

	public void onDiskHitTarget()	{
		++TargetHitCount;
		if (TargetHitCount == Disks.Length)
		{
			SceneManager.LoadScene(0);
			//StartCoroutine(ResetGame());
			//foreach (var disk in Disks)
			//{
			//	disk.ResetDisc();
			//}
			//TargetHitCount = 0;

		}
	}

	public IEnumerator ResetGame() {
		yield return new WaitForSeconds(0.30f);//must be after we finish shrinking the disks - UGLY
		foreach (var disk in Disks)
		{
			disk.ResetDisc();
		}
	}
}
