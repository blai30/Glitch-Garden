using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    private Button[] buttonArray;
	
	void Start() {
		buttonArray = GameObject.FindObjectsOfType<Button>();
	}
	
	void Update() {
		
	}

    void OnMouseDown() {
        print(name + " pressed");
        foreach (Button thisButton in buttonArray) {
            thisButton.GetComponent<SpriteRenderer>().color = Color.black;
        }
        GetComponent<SpriteRenderer>().color = Color.white;
    }

}
