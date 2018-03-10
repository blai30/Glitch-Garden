using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {

    public float levelSeconds = 100;
    private Slider slider;
    private AudioSource audioSource;
    private bool isEndOfLevel = false;
    private LevelManager levelManager;
    private GameObject winLabel;
	
	void Start() {
        slider = GetComponent<Slider>();
        audioSource = GetComponent<AudioSource>();
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        FindYouWin();
    }

    void FindYouWin() {
        winLabel = GameObject.Find("Win");
        if (!winLabel)
        {
            Debug.LogWarning("Please create You Win object");
        }
    }

    void Update() {
		slider.value = Time.timeSinceLevelLoad / levelSeconds;

        bool timeIsUp = Time.timeSinceLevelLoad >= levelSeconds;
        if (timeIsUp && !isEndOfLevel) {
            audioSource.Play();
            Invoke("LoadNextLevel", audioSource.clip.length);
            isEndOfLevel = true;
        }
	}

    void LoadNextLevel() {
        levelManager.LoadNextLevel();
    }

}
