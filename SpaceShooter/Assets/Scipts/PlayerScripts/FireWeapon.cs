﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : MonoBehaviour {
	//Cooldown for shooting
	public float fireDelay=0.5f;
	float cooldownTimer=0;



	//List of different bullets
	public List<GameObject> weapons=new List<GameObject>();
	//Index for the list, will get raised by one when powerup is picked up
	public int whichWeapon = 0;

	//Object pooling
	public List<GameObject> bulletPool= new List<GameObject>();
	public int bulletPoolSize;

	void Start () {
		for (int i = 0; i < bulletPoolSize; i++) {
			GameObject newBullet = Instantiate (weapons [whichWeapon]);
			newBullet.SetActive (false);
			bulletPool.Add (newBullet);

		}

	} 

	// Update is called once per frame
	void Update () {
		//there is a delay on shooting which can be decreased with a powerup
		cooldownTimer -= Time.unscaledDeltaTime;
		if (Input.GetButton ("Fire1")&& cooldownTimer <=0) {
			Debug.Log ("PWE");
			fireBullet ();
			cooldownTimer = fireDelay;
		}
	}

	private void fireBullet(){
		//bullet objectpooling
		foreach (GameObject bulletClone in bulletPool) {
			if (!bulletClone.activeSelf) {
				bulletClone.SetActive (true);
				break;

			}

		}




	}
}
