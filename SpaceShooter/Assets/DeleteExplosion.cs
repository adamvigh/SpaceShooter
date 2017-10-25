using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteExplosion : MonoBehaviour {
	public float explosionTime=1f;
	private bool isEnabled=false;
	// Use this for initialization
	void Start () {
		
	}
	void OnEnable(){
		isEnabled = true;

	}
	
	// Update is called once per frame
	void Update () {
		if (isEnabled) {
			explosionTime -= Time.unscaledDeltaTime;

		}
		if (explosionTime <= 0) {
			gameObject.SetActive (false);
			isEnabled = false;
			explosionTime = 1f;

		}
		
	}
}
