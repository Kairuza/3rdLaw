using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public Vector3 target;
	private Vector3 Test;
	private Vector3 v_diff;
	private float atan2;
	public GameObject admin;
	public static int PlayerHealth = 100;
	public static bool MaxHealth = true;

	// Use this for initialization
	void Start () {
	
		StartCoroutine(HealthRegenClock());

	}
	
	// Update is called once per frame
	void Update () {
	
		Test = Input.mousePosition;
		target = Camera.main.ScreenToWorldPoint (new Vector3 (Test.x, Test.y, 10.0f));
		v_diff = (target - transform.position);    
		atan2 = Mathf.Atan2 ( v_diff.y, v_diff.x );
		transform.rotation = Quaternion.Euler(0f, 0f, atan2 * Mathf.Rad2Deg );

		if (Input.GetMouseButton(0)){

			GetComponent<Rigidbody2D>().AddForce(((target - transform.position).normalized)* -5);
			
			}
		/*if (Input.GetKey (KeyCode.E)){
			
			while (Administrator.Score != 0){
				GetComponent<Rigidbody2D>().AddForce(((target - transform.position).normalized)* 0.5f);//<There is an issue here, not sure what it is. Might be a physcics thing
				Administrator.Score --;
			}


		}*/
		if (PlayerHealth == 100){

			MaxHealth = true;

		}
		if (PlayerHealth > 100){

			PlayerHealth = 100;

		}
	}

	void FixedUpdate(){
		if (Input.GetKey (KeyCode.E) && Administrator.Score > 0) {

			StartCoroutine ("Boosterclock");
		}
	}

	void OnTriggerEnter2D(Collider2D Other){

		if (Other.gameObject.tag == "EnemyBullet"){

			PlayerHealth -= 10;
			MaxHealth = false;
			Destroy(Other.gameObject);
			StartCoroutine(HealthRegenClock());

		}
		else if (Other.gameObject.tag == "Enemy"){

			PlayerHealth -= 25;
			MaxHealth = false;
			Destroy(Other.gameObject);
			StartCoroutine(HealthRegenClock());

		}
	}
	IEnumerator HealthRegenClock (){

		while (MaxHealth == false){

			yield return new WaitForSeconds (2);
			PlayerHealth+=2;
			
		}
	}
	IEnumerator Boosterclock (){

				yield return new WaitForSeconds (0.1f);
				GetComponent<Rigidbody2D> ().AddForce (((target - transform.position).normalized) * 5);
				Administrator.Score --;

	}
}
