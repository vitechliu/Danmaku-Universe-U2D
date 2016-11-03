using UnityEngine;
using System.Collections;
using Lib;

public class Particles : MonoBehaviour {

	private float size;
	private float blur;
	private Color color;
	public float minSize = 0.01f;
	public float maxSize = 0.05f;
	private SpriteRenderer sr;
	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> ();
		size = Random.Range (minSize, maxSize);
		if (Random.Range(1,11)<2) {
			
			color = DUlib.randColor ();
			sr.color = color;
		}
		DUlib.Hello ();
		float x = Random.Range(0f,Screen.width);
		float y = Random.Range(0f,Screen.height);
		float z = Random.Range(12f,50f);
		Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(x,y,z));


		transform.position = pos;
		transform.localScale = new Vector3 (size, size, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
		if (pos.x < 0)
			pos.x = Screen.width;
		else if (pos.x > Screen.width)
			pos.x = 0;
		if (pos.y < 0)
			pos.y = Screen.height;
		else if (pos.y > Screen.height)
			pos.y = 0;
		transform.position = Camera.main.ScreenToWorldPoint (pos);
		//Vector3 pos = Camera.main.WorldToScreenPoint(
	}
}
