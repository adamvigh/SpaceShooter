using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {
	public float speed;
	public float maxDistance;
	public float distanceTraveled = 0f;
	public bool hasMaxDistance;
	private Transform firePoint;



	// Use this for initialization
	void Start () {
		
	}
	void Awake(){
		//setting the point where the bullets are coming from
		firePoint = GameObject.FindGameObjectWithTag("FirePoint1").transform;
	}
	void OnEnable(){
		distanceTraveled = 0;
		transform.position = firePoint.position;

	}
	
	// Update is called once per frame
	void Update () {
		//moving and disableing after reaching maxdistance
		// I use unscaledDeltaTime here too because the player bullets should always move at normal speed
		Vector2 position = transform.position;
		position = new Vector2 (position.x, position.y + speed * Time.unscaledDeltaTime);
		transform.position = position;

		if (hasMaxDistance) {
			distanceTraveled += transform.position.y*Time.timeScale;
			if (distanceTraveled >= maxDistance) {
				gameObject.SetActive (false);
			}

		}
		
	}

}
