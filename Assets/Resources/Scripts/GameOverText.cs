using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class GameOverText : MonoBehaviour {

	public GameObject helicopter;
	private Text text;
	private int coins;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
		text.color = new Color(0, 0, 0, 0);
	}

	// Update is called once per frame
	void Update () {
		if (helicopter != null) {
			coins = helicopter.GetComponent<HeliController>().coinTotal;
		}
		else {
			text.color = new Color(0, 0, 0, 1);
			text.text = "Game Over\nYour Score:\n" + coins + " Coins\nPress Space to Restart!";
			if (Input.GetButtonDown("Jump")) {
				SceneManager.LoadScene("Main");
			}
		}
	}
}
