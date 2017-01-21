using UnityEngine;
using System.Collections;
using UnityEditor;

public class Disk : MonoBehaviour {

	Rigidbody2D body;
	//public Vector3 InitialScale { get; set; }
	//public Vector3 InitialPosition { get; set; }
	// Use this for initialization
	void Start()
	{
		//InitialScale = this.transform.localScale;
		//InitialPosition = this.transform.localPosition.normalized;
		float xp = Random.Range(-5f, 5f);
		float yp = Random.Range(-4f, 4f);
		float zp = 0;
		transform.position = new Vector3(xp, yp, zp);
	}
	void Awake()
	{
		//Vector3 direction = transform.position - Vector3.left * 5;
		body = GetComponent<Rigidbody2D>();

		//body.AddForceAtPosition (direction.normalized, transform.position);
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void Hit(Vector2 force) {
		body.AddForce (force);
	}

	public void OnCollisionEnter2D(Collision2D col)
	{
		//x.gameObject.tag == "Wall"
		if(col.gameObject.tag == "Target")
		{
			//this.transform.localScale = Vector3.zero;
			Debug.Log("OnCollisionEnter2D");
			//this.gameObject.GetComponent<Renderer>().enabled = false;
			StartCoroutine(Shrink());
		}

	}

	//public void ResetDisc()
	//{
	//	this.gameObject.GetComponent<Renderer>().enabled = true;
	//	//this.transform.localScale = Vector3.one;
	//	//Debug.Log(InitialPosition);
	//	//this.transform.Translate(new Vector3(5f,3f,1));
	//}

	IEnumerator Shrink()
	{
		for (int i = 0; i < 5; i++)
		{
			this.transform.localScale /= 10f;
			yield return new WaitForSeconds(0.05f);
		}
		this.transform.localScale = Vector3.zero;
	}
}
