using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSpeedPowerUp : MonoBehaviour {
	private GameObject player;
	// Use this for initialization
	void Start () {
		player=GameObject.FindGameObjectWithTag("Player");
	}
	void OnDisable(){
		Debug.Log("poweruphappened");
		if (player.GetComponent<FireWeapon> ().fireDelay >0.11f) {
				player.GetComponent<FireWeapon> ().fireDelay -= 0.1f;
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
