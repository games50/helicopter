using UnityEngine;
using System.Collections;

public class SkyscraperSpawner : MonoBehaviour {

	public GameObject[] prefabs;
	public static float speed = 10f;

	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnSkyscrapers());
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator SpawnSkyscrapers() {
		while (true) {
			Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(26, Random.Range(-20, -12), 11),
				Quaternion.Euler(-90f, 0f, 0f));
			if (Random.Range(1, 4) == 1) {
				speed += 1f;
			}
			yield return new WaitForSeconds(Random.Range(1, 5));
		}
	}
}
