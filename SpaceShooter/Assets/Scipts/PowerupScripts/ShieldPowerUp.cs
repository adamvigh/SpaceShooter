using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPowerUp : MonoBehaviour {
	public GameObject shield;
	// Use this for initialization
	void Start(){
		shield = GameObject.FindWithTag("Player").transform.GetChild(1).gameObject;

	}
	void OnDisable(){
		Debug.Log("Activated shield");
		shield.SetActive (true);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
