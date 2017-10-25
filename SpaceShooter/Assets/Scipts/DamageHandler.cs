using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour {
	public List<GameObject> explosions = new List<GameObject> ();
	public int health =1;
	public GameObject explosion;
	public int explosionPoolSize = 5;

	void Start(){

		for (int i = 0; i < explosionPoolSize; i++) {
			GameObject newExplosion = Instantiate (explosion);
			newExplosion.SetActive (false);
			explosions.Add (newExplosion);

		}


	}

	void OnTriggerEnter2D(){
		Crash ();


	}
	public void Crash(){
		Debug.Log ("Utkozes");
		health--;
		if (health <= 0) {
			foreach (GameObject explode in explosions) {
				if (!explode.activeSelf) {
					explode.transform.position = transform.position;
					explode.SetActive (true);
					break;

				}


			}
			gameObject.SetActive (false);

		}


	}
}
