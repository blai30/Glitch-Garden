﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public float health = 100f;
	
	void Start() {
		
	}
	
	void Update() {
		
	}

    public void DealDamage(float damage) {
        health -= damage;

        }
    }

}
