using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour {

    public int starCost = 100;
    private StarDisplay starDisplay;
	
	void Start() {
		starDisplay = GameObject.FindObjectOfType<StarDisplay>();
	}
	
	void Update() {
		
	}

    public void AddStars(int amount) {
        starDisplay.AddStars(10);
    }

}
