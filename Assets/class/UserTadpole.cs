using UnityEngine;
using System.Collections;

public class UserTadpole : Tadpole {

	public static UserTadpole me;

	void Start () {
		base.Start ();
		me = this;
	}
	
	// Update is called once per frame
	void Update () {
		base.Update ();
	}
}
