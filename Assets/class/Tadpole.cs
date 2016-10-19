using UnityEngine;
using System.Collections;
using System;

public class Tadpole : MonoBehaviour {

	// Use this for initialization
	private Rigidbody2D r2d;

	public float maxSpeed = 5;
	public float speed = 0;
	public float acc;

	public void Start () {
		r2d = GetComponent<Rigidbody2D> ();
		acc = maxSpeed * 20;
	}

	// Update is called once per frame
	public void Update () {
		
	}

	public void FixedUpdate(){
		acc = maxSpeed * 20;
		r2d.velocity = Vector2.ClampMagnitude (r2d.velocity, maxSpeed);
		float tx = Input.GetAxis("Horizontal") * acc;
		float ty = Input.GetAxis ("Vertical") * acc;
		speed = r2d.velocity.magnitude;
		Vector2 accAdd = new Vector2(tx,ty);
		accAdd = Vector2.ClampMagnitude (accAdd, acc);
		r2d.AddForce (accAdd,ForceMode2D.Force);
		r2d.velocity = Vector2.ClampMagnitude (r2d.velocity, maxSpeed);
	}
}
