	using UnityEngine;
using System.Collections;

public class Spanwer : MonoBehaviour {

	public GameObject Enemy1;
	public GameObject Enemy2;
	public GameObject Enemy3;
	public bool clock = true;
	public GameObject Boss1;
	public static int Counter = 0;
	public static int TriggerState = 5;
	private int StateControl = 1;
	private int Var1 = 0; //State Changer
	private float Var2; //Location Randomiser
	private int var3;	//Spawn Randomiser



	// Use this for initialization
	void Start () {

		StartCoroutine(Clock());
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (Counter == TriggerState){

			clock = false;
			Var2 = Random.Range (-10,10);

			switch (StateControl){

			case 1:

				Instantiate(Enemy1, new Vector3 (gameObject.transform.position.x + Var2, gameObject.transform.position.y,0), Quaternion.identity);
				Var1 ++;
				if (Var1 == 15){

					StateControl ++;
					TriggerState = 4;

				}
				Counter = 0;
				clock = true;

				break;

			case 2:

				var3 = Random.Range (0,3);
				switch (var3){

				case 1:

					Instantiate(Enemy2, new Vector3 (gameObject.transform.position.x + Var2, gameObject.transform.position.y,0), Quaternion.identity);
					Var1 ++;
					if (Var1 == 30){
				
						StateControl ++;
						TriggerState = 3;
						
					}
					Counter = 0;
					clock = true;
					break;

				default:

					Instantiate(Enemy1, new Vector3 (gameObject.transform.position.x + Var2, gameObject.transform.position.y,0), Quaternion.identity);
					Var1 ++;
					if (Var1 == 30){
						
						StateControl ++;
						TriggerState = 3;
						
					}
					Counter = 0;
					clock = true;

					break;
				}


				break;


			case 3:

				var3 = Random.Range (0,3);
				switch (var3){
					
				case 1:
					
					Instantiate(Enemy2, new Vector3 (gameObject.transform.position.x + Var2, gameObject.transform.position.y,0), Quaternion.identity);
					Counter = 0;
					clock = true;
					break;

				case 2:

					Instantiate(Enemy3, new Vector3 (gameObject.transform.position.x + Var2, gameObject.transform.position.y,0), Quaternion.identity);
					Counter = 0;
					clock = true;
					break;
					
				default:
					
					Instantiate(Enemy1, new Vector3 (gameObject.transform.position.x + Var2, gameObject.transform.position.y,0), Quaternion.identity);
					Counter = 0;
					clock = true;
					
					break;
				}

				break;
			}
		}
		//if (Administrator.Score == 5000) {

		//	Instantiate(Boss1, new Vector3 (gameObject.transform.position.x,gameObject.transform.position.y,0),Quaternion.identity);

		//}
	
	}

	IEnumerator Clock (){

		while (clock == true){

			yield return new WaitForSeconds (0.3f);
			Counter ++;

		}

	}
}
