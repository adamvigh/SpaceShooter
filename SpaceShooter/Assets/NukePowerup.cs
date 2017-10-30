using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NukePowerup : MonoBehaviour {
	private GameObject asteroids;
	// Use this for initialization
	void Start () {
		asteroids = GameObject.FindWithTag ("Spawner");
	}
	void OnDisable(){
		if (gameObject.GetComponent<PowerupExpire> ().powerUpCountDown > 0) {
			foreach (GameObject asteroidClone in asteroids.GetComponent<Spawn>().asteroidPool) {
				if (asteroidClone.activeSelf) {
					asteroidClone.SetActive (false);
					asteroidClone.GetComponent<DamageHandler> ().Explode ();

				}

			}
		}




	}
	// Update is called once per frame
	void Update () {
		
	}
}
