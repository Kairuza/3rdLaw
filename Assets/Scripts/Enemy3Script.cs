using UnityEngine;
using System.Collections;

public class Enemy3Script : MonoBehaviour {

	private int Health = 5;
	public GameObject ScoreZone;
	public GameObject EnemyBullet;

	// Use this for initialization
	void Start () {
	
		StartCoroutine (Clock ());
		StartCoroutine (Death ());

	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<Rigidbody2D>().velocity = new Vector2 (0,-2);
		if (Health <= 0){

			Instantiate(ScoreZone, new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
			Destroy(gameObject);

		}

	}

	void OnTriggerEnter2D(Collider2D Other){
		Destroy (Other.gameObject);
		if (Other.gameObject.tag == "Bullet"){
			Health --;
			//Destroy (Other.gameObject);
		}
	}
	IEnumerator Clock(){
		
		while(true){
			
			yield return new WaitForSeconds (1);
			Instantiate(EnemyBullet, new Vector3(gameObject.transform.position.x + 0.3f, gameObject.transform.position.y - 2, gameObject.transform.position.z),Quaternion.identity);
			Instantiate(EnemyBullet, new Vector3(gameObject.transform.position.x - 0.3f, gameObject.transform.position.y - 2, gameObject.transform.position.z),Quaternion.identity);
		}
	}

	IEnumerator Death(){
		
		yield return new WaitForSeconds (65);
		Destroy(gameObject);
		
	}
}
