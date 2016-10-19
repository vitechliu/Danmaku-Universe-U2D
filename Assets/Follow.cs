using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 vv = new Vector3( UserTadpole.me.transform.position.x, UserTadpole.me.transform.position.y,transform.position.z);
		float delta = 10 * Time.deltaTime;
		transform.position = Vector3.Lerp (transform.position,vv, delta);

	}
}
