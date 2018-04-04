using UnityEngine;
using System.Collections;

public class SlimeMoveTest : MonoBehaviour {

	void Update () {

		transform.Translate (Vector3.forward / 60);
		transform.Rotate (Vector3.up * 1.5f);
	
	}
}
