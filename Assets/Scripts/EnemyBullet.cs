using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		GetComponent<Rigidbody2D>().velocity = new Vector2 (0,-4);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
