using UnityEngine;
using System.Collections;

public class Enemy1Script : MonoBehaviour {

	public GameObject ScoreZone;

	// Use this for initialization
	void Start () {

		GetComponent<Rigidbody2D>().velocity = new Vector2 (0,-3);
		StartCoroutine ("Death");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D Other){

		if (Other.gameObject.tag == "Bullet"){

			print ("Hit");

			Instantiate(ScoreZone, new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
			Destroy (Other.gameObject);
			Destroy (gameObject);
		}
	}

	IEnumerator Death(){

		yield return new WaitForSeconds (50);
		Destroy(gameObject);

	}
}
