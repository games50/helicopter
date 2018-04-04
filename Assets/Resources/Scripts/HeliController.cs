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

		// vertical axis is either up or down or w and s on the keyboard, among others
		if (Input.GetAxisRaw("Vertical") != 0) {
			vertical = Input.GetAxis("Vertical") * speed;

			// constrain movement within the bounds of the camera
			if (transform.position.y < -9.5f) {
				transform.position = new Vector3(transform.position.x, -9.5f, transform.position.z);
			}
			if (transform.position.y > 9) {
				transform.position = new Vector3(transform.position.x, 9, transform.position.z);
			}
		} else {
			vertical = 0f;
		}

		// horizontal axis is either left or right or a and d on the keyboard, among others
		if (Input.GetAxisRaw("Horizontal") != 0) {
			horizontal = Input.GetAxis("Horizontal") * speed;

			// constrain movement within the bounds of the camera
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

		// set rigidbody's velocity to our input
		rb.velocity = new Vector3(horizontal, vertical, 0);
	}

	public void PickupCoin() {
		coinTotal += 1;

		// trigger audio playback and emit particles from particle system
		GetComponents<AudioSource>()[0].Play();
		GetComponent<ParticleSystem>().Play();
	}

	public void Explode() {
		explosionSound.Play();

		// set explosion position to helicopter's and emit
		explosion.transform.position = transform.position;
		explosion.Play();
		
		Destroy(gameObject);
	}
}
