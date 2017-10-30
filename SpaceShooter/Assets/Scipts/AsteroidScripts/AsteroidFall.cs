using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidFall : MonoBehaviour {
	public float speed = 4f;
	public float maxDistance=900f;
	public float distanceTraveled = 0f;
	public bool hasMaxDistance=true;
	// Use this for initialization
	void Start () {
		
	}
	void OnEnable(){
		distanceTraveled = 0;


	}
	
	// Update is called once per frame
	void Update () {
		//Falling and rotateing
		Vector2 fall = transform.position;
		fall = new Vector2 (fall.x, fall.y - speed*Time.deltaTime);
		transform.position = fall;
		transform.Rotate (Vector3.forward * -1*Time.timeScale);
		if (hasMaxDistance) {
			distanceTraveled += Mathf.Abs(transform.position.y*Time.timeScale);
			if (distanceTraveled >= maxDistance) {
				gameObject.SetActive (false);
			}

		}

	}

}
