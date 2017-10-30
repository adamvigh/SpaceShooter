using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers : MonoBehaviour {

	public float slowdownLength=10f;
	public float timeSlowCooldown;
	public float invincibilityTime=2f;
	public bool isInvincible=false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (invincibilityTime <= 0) {
			gameObject.GetComponent<BoxCollider2D> ().enabled = true;
			isInvincible = false;
			invincibilityTime = 2f;
		}
		if(Input.GetKeyDown("f")&&!isInvincible){
			isInvincible=true;
			gameObject.GetComponent<BoxCollider2D> ().enabled = false;
		}
		if (isInvincible) {
			invincibilityTime -= Time.unscaledDeltaTime;
		}


		if (Input.GetKeyDown ("e")) {

			DoSlowmotion ();
		}
		Time.timeScale += (1f / slowdownLength)*Time.unscaledDeltaTime;
		Time.timeScale = Mathf.Clamp (Time.timeScale, 0f, 1f);
		
	}
	public void DoSlowmotion(){
		Time.timeScale = 0.05f;
		Time.fixedDeltaTime = Time.timeScale * 0.02f;

	}
}
