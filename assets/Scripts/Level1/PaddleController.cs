using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {

	float joystickForce = 85;
	new Rigidbody2D rigidbody2D;

	// Use this for initialization
	void Start () {
		rigidbody2D = GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void Update () {
		float direction = Input.GetAxisRaw ("Horizontal");
		Vector2 forceWanted = new Vector2 (direction * joystickForce, 0);



		rigidbody2D.AddForce (forceWanted);
	}
}
