using UnityEngine;
using System.Collections;

public class ShieldController : MonoBehaviour {

	public Sprite shield1;
	public Sprite shield2;
	public Sprite shield3;
	public Sprite shield4;
	private SpriteRenderer sprite;


	// Use this for initialization
	void Start () {
	
		sprite = gameObject.GetComponent<SpriteRenderer>();
		//sprite.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (PlayerController.MaxHealth == false){
			sprite.enabled = true;
			if (PlayerController.PlayerHealth > 75){
				sprite.sprite = shield1;
			}
			else if (PlayerController.PlayerHealth >= 50 && PlayerController.PlayerHealth < 75){
				sprite.sprite = shield2;
			}
			else if (PlayerController.PlayerHealth >= 25 && PlayerController.PlayerHealth < 50){
				sprite.sprite = shield3;
			}
			else if (PlayerController.PlayerHealth >= 10 && PlayerController.PlayerHealth < 25 ){
				sprite.sprite = shield4;
			}
			else if (PlayerController.PlayerHealth <10)
				sprite.enabled = false;
		}
		else{

			sprite.enabled = false;

		}

	}
}