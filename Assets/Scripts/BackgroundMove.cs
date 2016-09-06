using UnityEngine;
using System.Collections;

public class BackgroundMove : MonoBehaviour {
	public float moveSpeed;
	public GameObject target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		gameObject.transform.position = Vector2.Lerp(transform.position,target.transform.position, moveSpeed*Time.fixedDeltaTime);
	}
}
