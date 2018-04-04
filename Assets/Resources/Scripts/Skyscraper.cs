using UnityEngine;
using System.Collections;

public class Skyscraper : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x < -25) {
			Destroy(gameObject);
		}
		else {
			transform.Translate(-SkyscraperSpawner.speed * Time.deltaTime, 0, 0);
		}
	}

	void OnTriggerEnter(Collider other) {
		other.transform.parent.gameObject.GetComponent<HeliController>().Explode();
	}
}
