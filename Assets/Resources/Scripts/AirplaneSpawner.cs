using UnityEngine;
using System.Collections;

public class AirplaneSpawner : MonoBehaviour {
	public GameObject[] prefabs;

	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnAirplanes());
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator SpawnAirplanes() {
		while (true) {
			Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(26, Random.Range(7, 10), 11),
				Quaternion.Euler(-90f, -90f, 0f));

			yield return new WaitForSeconds(Random.Range(3, 10));
		}
	}
}
