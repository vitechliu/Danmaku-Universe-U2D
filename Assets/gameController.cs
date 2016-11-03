using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {
	public GameObject particles;
	// Use this for initialization
	void Start () {
		for (int i=0;i<200;i++) Instantiate (particles);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
