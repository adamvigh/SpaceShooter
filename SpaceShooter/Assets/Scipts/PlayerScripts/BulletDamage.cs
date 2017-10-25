using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour {
	public int health =1;

	void OnTriggerEnter2D(){
		Debug.Log ("Utkozes");
		health--;
		if (health <= 0) {
			
			gameObject.SetActive (false);

		}

	}
}
