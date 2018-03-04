﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {

    [Range(-1f, 1.5f)]
    public float currentSpeed;
	
	void Start() {
		Rigidbody2D myRigidbody = gameObject.AddComponent<Rigidbody2D>();
        myRigidbody.isKinematic = true;
	}
	
	void Update() {
		transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
	}

    void OnTriggerEnter2D() {
        Debug.Log(name + " trigger enter");
    }

    public void SetSpeed(float speed) {
        currentSpeed = speed;
    }

}
