﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Attacker : MonoBehaviour {

    private float currentSpeed;
    private GameObject currentTarget;
    private Animator animator;
	
	void Start() {
		animator = GetComponent<Animator>();
	}
	
	void Update() {
		transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
        if (!currentTarget) {
            animator.SetBool("isAttacking", false);
        }
	}

    void OnTriggerEnter2D() {
        Debug.Log(name + " trigger enter");
    }

    public void SetSpeed(float speed) {
        currentSpeed = speed;
    }

    // Called from the animator at time of actual blow
    public void StrikeCurrentTarget(float damage) {
        if (currentTarget) {
            Health health = currentTarget.GetComponent<Health>();
            if (health) {
                health.DealDamage(damage);
            }
        }
        Debug.Log(name + " caused damage: " + damage);
    }

    public void Attack(GameObject obj) {
        currentTarget = obj;
    }

}
