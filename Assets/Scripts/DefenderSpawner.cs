using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {
	
	void Start() {
		
	}
	
	void Update() {
		
	}

    void OnMouseDown() {
        print(Input.mousePosition);
        print(CalculateWorldPointOfMouseClick());
    }

    Vector2 CalculateWorldPointOfMouseClick() {
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;

        
    }

}
