using UnityEngine;
using System.Collections;

public class HeliController : MonoBehaviour {

	public float speed = 10.0f;
	public int coinTotal = 0;
	private Rigidbody rb;
	private float vertical, horizontal;
	public ParticleSystem explosion;
	public AudioSource explosionSound;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetAxisRaw("Vertical") != 0) {
			vertical = Input.GetAxis("Vertical") * speed;
			if (transform.position.y < -9.5f) {
				transform.position = new Vector3(transform.position.x, -9.5f, transform.position.z);
			}
			if (transform.position.y > 9) {
				transform.position = new Vector3(transform.position.x, 9, transform.position.z);
			}
		} else {
			vertical = 0f;
		}

		if (Input.GetAxisRaw("Horizontal") != 0) {
			horizontal = Input.GetAxis("Horizontal") * speed;
			if (transform.position.x < -12.5f) {
				transform.position = new Vector3(-12.5f, transform.position.y, transform.position.z);
			}
			if (transform.position.x > 15.5f) {
				transform.position = new Vector3(15.5f, transform.position.y, transform.position.z);
			}
		}
		else {
			horizontal = 0f;
		}

		rb.velocity = new Vector3(horizontal, vertical, 0);
	}

	public void PickupCoin() {
		coinTotal += 1;
		GetComponents<AudioSource>()[0].Play();
		GetComponent<ParticleSystem>().Play();
	}

	public void Explode() {
		explosionSound.Play();
		explosion.transform.position = transform.position;
		explosion.Play();
		Destroy(gameObject);
	}
}
