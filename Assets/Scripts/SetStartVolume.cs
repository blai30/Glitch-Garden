using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStartVolume : MonoBehaviour {

    private MusicManager musicManager;
	
	void Start() {
		musicManager = GameObject.FindObjectOfType<MusicManager>();
        if (musicManager) {
            Debug.Log("Found music manager: " + musicManager);
            float volume = PlayerPrefsManager.GetMasterVolume();
            musicManager.SetVolume(volume);
        } else {
            Debug.LogWarning("No music manager found");
        }
	}
	
	void Update() {
		
	}

}
