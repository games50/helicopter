using UnityEngine;
using System.Collections;

public class PlatformLiftTest : MonoBehaviour
{

	Vector3 startPos;
	float sinFloat;

	void Start ()
	{

		startPos = transform.position;
	
	}
	
	void Update ()
	{

		sinFloat = Mathf.Sin (Time.time) / 2 + 0.5f;
		transform.position = startPos + new Vector3 (0f, sinFloat, 0f);
	
	}
}
