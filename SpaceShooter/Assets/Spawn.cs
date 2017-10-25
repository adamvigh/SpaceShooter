using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
	public List<GameObject> asteroidPool = new List<GameObject>();
	public GameObject asteroid;
	public int poolSize=10;
	public float cooldown=0.01f;
	public float countdown=1f;

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
		countdown -= Time.deltaTime;
		if (countdown <= 0) {
			spawnAsteroid();
			countdown += cooldown;

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
}
