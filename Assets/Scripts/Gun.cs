using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public GameObject Bullet;
	private bool Fire = true;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton (0) && Fire == true){

			Instantiate(Bullet, transform.position, transform.rotation);
			Fire = false;
			StartCoroutine (Clock());
			

		}
	}
	IEnumerator Clock(){

		while (Fire == false){
			yield return new WaitForSeconds (0.1f);
			Fire = true;
		}
	}
}
