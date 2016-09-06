using UnityEngine;
using System.Collections;

public class Administrator : MonoBehaviour {

	public static int Score = 0;
	GameObject Player;

	// Use this for initialization
	void Start () {
	
		Player = GameObject.FindGameObjectWithTag ("Player");

	}
	
	// Update is called once per frame
	void Update () {
	
		if (PlayerController.PlayerHealth <= 0) {

			Dead ();

		}
		if (Score < 0) {

			Score = 0;

		}

	}
	void OnGUI (){

		GUI.Box (new Rect (0,0,100,50), "Score" + Score);

	}

	void Dead(){

		Application.LoadLevel (Application.loadedLevel);

	}
}
