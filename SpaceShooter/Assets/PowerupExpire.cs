using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupExpire : MonoBehaviour {
	public float powerUpCountDown=5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		powerUpCountDown -= Time.unscaledDeltaTime;
		if (powerUpCountDown <= 0) {
			Destroy (gameObject);
		}
		
	}
}
