using UnityEngine;
using System.Collections;

public class Airplane : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		// if airplane goes past the left edge, destroy it
		if (transform.position.x < -25) {
			Destroy(gameObject);
		}
		else {

			// make it go twice as fast as the skyscraper spawner speed toward the left
			transform.Translate(-SkyscraperSpawner.speed * 2 * Time.deltaTime, 0, 0, Space.World);
		}
	}

	void OnTriggerEnter(Collider other) {

		// trigger helicopter's explode function via HeliController component
		// and then destroy this airplane as well
		other.transform.parent.gameObject.GetComponent<HeliController>().Explode();
		Destroy(gameObject);
	}
}
