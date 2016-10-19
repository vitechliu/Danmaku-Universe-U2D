using UnityEngine;
using System.Collections;
using Lib;

public class Particles : MonoBehaviour {

	private float size;
	private float blur;
	private Color color;
	[SerializeField]public static float minSize = 1;
	[SerializeField]public static float maxSize =3;
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

		Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector2(x,y));

		pos.z = Random.Range(1f,10f);
		transform.position = pos;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
