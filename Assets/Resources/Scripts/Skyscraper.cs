using UnityEngine;
using System.Collections;

public class Skyscraper : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		// despawn when past left edge of the screen (camera)
		if (transform.position.x < -25) {
			Destroy(gameObject);
		}
		else {

			// scroll based on SkyscraperSpawner static variable, speed
			transform.Translate(-SkyscraperSpawner.speed * Time.deltaTime, 0, 0);
		}
	}

	void OnTriggerEnter(Collider other) {

		// trigger helicopter to explode when it collides with this
		other.transform.parent.gameObject.GetComponent<HeliController>().Explode();
	}
}
