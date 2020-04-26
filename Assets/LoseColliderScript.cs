﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseColliderScript : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player"){
			Destroy(other.gameObject);
			SceneManager.LoadScene("Menu");
		}
	}
}
