using UnityEngine;
using System.Collections;

public class Enemy2Script : MonoBehaviour {

	public GameObject ScoreZone;
	public GameObject EnemyBullet;

	// Use this for initialization
	void Start () {
	
		GetComponent<Rigidbody2D>().velocity = new Vector2 (0,-3);
		StartCoroutine(Clock());
		StartCoroutine(Death());

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D Other){
		
		if (Other.gameObject.tag == "Bullet"){
			Instantiate(ScoreZone, new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
			Destroy (Other.gameObject);
			Destroy (gameObject);

		}
	}
	IEnumerator Clock(){

		while(true){

			yield return new WaitForSeconds (1);
			Instantiate(EnemyBullet, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.6f, gameObject.transform.position.z),Quaternion.identity);

		}
	}
	IEnumerator Death(){
		
		yield return new WaitForSeconds (50);
		Destroy(gameObject);
		
	}
}
