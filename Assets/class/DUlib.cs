using UnityEngine;
using System.Collections;

namespace Lib{
	public class DUlib {
		public static Color randColor() {
			return new Color (Random.Range (0f, 254f), Random.Range (0f, 254f), Random.Range (0f, 254f), Random.Range (0f, 1f));
		}
		public static void Hello(){
			Debug.Log ("Hello");
		}
	}
}