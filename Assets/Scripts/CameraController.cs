using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject Player;

	// Use this for initialization
	void Start () {
	
		Player = GameObject.FindGameObjectWithTag ("Player");

	}
	
	// Update is called once per frame
	void Update () {
	
		gameObject.transform.position = new Vector3 (Player.transform.position.x,Player.transform.position.y,-10);

	}
}
