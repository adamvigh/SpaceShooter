 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour {
	public float speed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		float x = Input.GetAxisRaw ("Horizontal");
		float y = Input.GetAxisRaw ("Vertical");

		Vector2 direction = new Vector2 (x, y).normalized;

		Move (direction);
		
	}
	void Move(Vector2 direction){

		Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0));
		Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1, 1));

		Vector2 pos = transform.position;
		//offsets
		max.x = max.x - 0.300f;
		min.x = min.x + 0.300f;
		min.y = min.y + 0.85f;

		pos += direction * speed * Time.unscaledDeltaTime;

		//Stops the ship from goind out of bounds
		pos.x = Mathf.Clamp (pos.x, min.x, max.x);
		pos.y = Mathf.Clamp (pos.y, min.y, max.y);
		transform.position = pos;




	}
}
