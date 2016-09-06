using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public Vector3 target;
	private Vector3 Test;
	private Vector3 v_diff;
	private float atan2;

	// Use this for initialization
	void Start () {

		Test = Input.mousePosition;
		target = Camera.main.ScreenToWorldPoint (new Vector3 (Test.x, Test.y, 10.0f));
		v_diff = (target - transform.position);    
		atan2 = Mathf.Atan2 ( v_diff.y, v_diff.x );
		transform.rotation = Quaternion.Euler(0f, 0f, atan2 * Mathf.Rad2Deg );
		GetComponent<Rigidbody2D>().AddForce(((target - transform.position).normalized)* 1000);
		StartCoroutine ("Deathclock");

	
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	IEnumerator Deathclock () {

		yield return new WaitForSeconds (5);
		Destroy (gameObject);

	}
}
