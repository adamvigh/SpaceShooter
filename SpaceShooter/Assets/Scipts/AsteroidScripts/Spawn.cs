using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
	//Asteroid variables
	[Header("ASTEROID")]
	public List<GameObject> asteroidPool = new List<GameObject>();
	public GameObject asteroid;
	public int poolSize=10;
	public float asteroidCooldown=0.01f;
	public float asteroidCountdown=1f;
	//
	//Powerup variables
	[Header("POWERUP")]
	public float powerUpCountdown=10f;
	public float powerUpCooldown=10f;
	public GameObject[] powerUps;
	public float xMin = -3f;
	public float xMax = 3f;
	public float yMin = -4f;
	public float yMax = 4f;


	// Use this for initialization
	void Start () {
		for (int i = 0; i < poolSize; i++) {
			GameObject newBullet = Instantiate (asteroid);
			newBullet.SetActive (false);
			asteroidPool.Add(newBullet);

		}
		
	}

	
	// Update is called once per frame
	void Update () {
		asteroidCountdown -= Time.deltaTime;
		powerUpCountdown -= Time.unscaledDeltaTime;
		if (asteroidCountdown <= 0) {
			spawnAsteroid();
			asteroidCountdown += asteroidCooldown;

		}
		if (powerUpCountdown <= 0) {
			spawnPowerup ();
			powerUpCountdown = powerUpCooldown;

		}


		
	}
	private void spawnAsteroid(){
		Vector2 position = new Vector2 (Random.Range (-3f, 3f),5.5f);

		foreach (GameObject asteroidClone in asteroidPool) {
			if (!asteroidClone.activeSelf) {
				asteroidClone.transform.position = position;
				asteroidClone.SetActive (true);
				break;

			}
				
		}

	}
	private void spawnPowerup(){
		Vector2 pos = new Vector2 (Random.Range (xMin, xMax), Random.Range (yMin, yMax));
		GameObject powerUp = powerUps [Random.Range (0, powerUps.Length)];
		Instantiate (powerUp, pos,Quaternion.identity);
	}
}
