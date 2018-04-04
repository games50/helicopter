using UnityEngine;
using System.Collections;

public class Airplane : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x < -25) {
			Destroy(gameObject);
		}
		else {
			transform.Translate(-SkyscraperSpawner.speed * 2 * Time.deltaTime, 0, 0, Space.World);
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other != null) {
			other.transform.parent.gameObject.GetComponent<HeliController>().Explode();
			Destroy(gameObject);
		}
	}
}
