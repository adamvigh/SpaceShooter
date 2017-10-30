using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteExplosion : MonoBehaviour {
	public float explosionTime=0.5f;
	private bool isEnabled=false;
	// Use this for initialization
	void Start () {
		
	}
	void OnEnable(){
		isEnabled = true;

	}
	
	// Update is called once per frame
	void Update () {
		//when explosion activates a timer starts and at the end of it it disables the explosion
		if (isEnabled) {
			explosionTime -= Time.unscaledDeltaTime;

		}
		if (explosionTime <= 0) {
			gameObject.SetActive (false);
			isEnabled = false;
			explosionTime = 0.5f;

		}
		
	}
}
