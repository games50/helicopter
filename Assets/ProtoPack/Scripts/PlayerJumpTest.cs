using UnityEngine;
using System.Collections;

public class PlayerJumpTest : MonoBehaviour
{
	
	Animator anim;
	Rigidbody rb;
	bool jump = false;

	void Start ()
	{
		
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody> ();

	}

	void Update ()
	{

	}
	
	void OnMouseDown ()
	{

		if (!jump) {
			jump = true;
			anim.SetBool ("jump", true);
			anim.SetBool ("land", false);
			rb.AddForce (Vector3.up * 200);
		}

	}

	void OnCollisionEnter ()
	{

		if (jump) {
			Invoke ("JumpReset", 0.25f);
			anim.SetBool ("jump", false);
			anim.SetBool ("land", true);
		}
	}

	void JumpReset ()
	{
		jump = false;
	}
	
}
