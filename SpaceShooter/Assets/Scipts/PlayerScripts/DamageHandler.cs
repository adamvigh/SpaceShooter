using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour {
	public List<GameObject> explosions = new List<GameObject> ();
	public int damage = 0;
	public int health =1;
	public GameObject explosion;
	public int explosionPoolSize = 5;
	public GameObject respawnPoint;



	void Start(){
		

		//Objectpooling setup
		for (int i = 0; i < explosionPoolSize; i++) {
			GameObject newExplosion = Instantiate (explosion);
			newExplosion.SetActive (false);
			explosions.Add (newExplosion);

		}


	}

	void OnTriggerEnter2D(Collider2D other){
		Crash (other);


	}
	public void Crash(Collider2D other){
		Debug.Log ("Utkozes");
		health -= other.GetComponent<DamageHandler>().damage;

		//Dont need explosions when pickung up powerups and when bullets collide
		if (other.tag!="Powerup" && gameObject.tag!="Bullet" ) {
			Explode ();



		}
	
		//Destroying
		if (health <= 0) {
			Debug.Log ("Game over");
			if (gameObject.tag == "Powerup") {
				Destroy (gameObject);
			}
			gameObject.SetActive (false);

		}
		//If tag is player then respawn at respawn point if not destroyed
		else if (gameObject.tag == "Player" && other.tag!="Powerup") {
			transform.position = respawnPoint.transform.position;


		}
			

	} 
	public void Explode(){
		foreach (GameObject explode in explosions) {
			if (!explode.activeSelf) {
				explode.transform.position = transform.position;
				explode.SetActive (true);
				break;
			}
		}


	}
}

