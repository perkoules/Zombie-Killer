using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSound : MonoBehaviour {

	private AudioSource bulletSound;

	// Use this for initialization
	void Start () {
		bulletSound = GetComponent<AudioSource>();
		bulletSound.Play();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
