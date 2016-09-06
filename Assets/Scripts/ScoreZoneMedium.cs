using UnityEngine;
using System.Collections;

public class ScoreZoneMedium : MonoBehaviour {

	public int PotentialPoints = 200;
	bool Decay;
	
	// Use this for initialization
	void Start () {
		
		Decay = true;
		StartCoroutine (DecayTimer());
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (PotentialPoints <= 0){
			
			Destroy(gameObject);
			
		}
	}
	void OnTriggerEnter2D (Collider2D Other){
		
		if (Other.gameObject.tag == "Player"){
			
			Decay = false;
			
		}
	}
	
	void OnTriggerStay2D (Collider2D Other){
		
		if (Other.gameObject.tag == "Player") {
			
			PotentialPoints -= 10;
			Administrator.Score += 10;
			gameObject.transform.localScale -= new Vector3 (0.1f, 0.1f, 0);
			
		}
		
	}
	void OnTriggerExit2D (Collider2D Other){
		
		if (Other.gameObject.tag == "Player"){
			Decay = true;
			StartCoroutine(DecayTimer());
		}
		
	}
	IEnumerator DecayTimer(){
		
		while (Decay == true){
			
			yield return new WaitForSeconds (0.5f);
			PotentialPoints --;
			gameObject.transform.localScale -= new Vector3(0.01f,0.01f,0);
			
		}
		
		
	}
}
