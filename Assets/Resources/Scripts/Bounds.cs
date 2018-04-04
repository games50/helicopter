using UnityEngine;
using System.Collections;

public class Bounds : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		float speed = other.transform.parent.gameObject.GetComponent<HeliController>().speed;
		
		other.transform.parent.gameObject.transform.Translate(-other.transform.parent.gameObject.GetComponent<Rigidbody>().velocity / speed);
		other.transform.parent.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
	}
}
