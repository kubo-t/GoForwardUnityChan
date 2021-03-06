﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	private float speed = -0.2f;
	private float deadLine = -10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (this.speed, 0, 0);

		if(transform.position.x < this.deadLine){
			Destroy (this.gameObject);
		}
	}

	public void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag != "Player"){
			GetComponent<AudioSource> ().Play ();
		}
	}
}
