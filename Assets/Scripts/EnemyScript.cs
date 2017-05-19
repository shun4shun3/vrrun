﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			Debug.Log ("collided with enemy");
			Destroy (this.gameObject);
			other.gameObject.SendMessage ("HitEnemy");
			other.gameObject.transform.localScale = new Vector3 (0.7f, 0.7f, 0.7f);

		}
	}
}
