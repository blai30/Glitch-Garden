using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour {

    private Animator anim;
	
	void Start() {
		anim = GetComponent<Animator>();
	}
	
	void Update() {
		
	}

    void OnTriggerEnter2D(Collider2D collider) {
        GameObject obj = collider.gameObject;

        if (!obj.GetComponent<Defender>()) {
            return;
        }

        if (obj.GetComponent<Stone>()) {
            anim.SetTrigger("jumpTrigger");
        } else {
            
        }

        Debug.Log("Fox collided with " + collider);
    }

}
