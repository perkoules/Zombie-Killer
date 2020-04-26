using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadMenuScript : MonoBehaviour {

	Text loadMenuLevel;

	// Use this for initialization
	void Start () {
		loadMenuLevel = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float time  = 6 - (Mathf.RoundToInt(Time.realtimeSinceStartup));
		loadMenuLevel.text = time.ToString();
		if (time <= 0){
			SceneManager.LoadScene("Menu");
		}
	}
}
