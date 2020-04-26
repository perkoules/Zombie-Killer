using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public GameObject bulletsToSpawn, bulletsSpawnPoint;
	private GameObject [] zombiesLeft;
	private Text healthText, zombiesText;

	// Use this for initialization
	void Start () {
		healthText  = GameObject.FindGameObjectWithTag("HealthText").GetComponent<Text>();
		zombiesText  = GameObject.FindGameObjectWithTag("ZombiesLeft").GetComponent<Text>();
		PlayerPrefsManager.SetPlayerHealth(1000);
		PlayerPrefsManager.SetPlayerDamage(10);		
	}
	
	// Update is called once per frame
	void Update () {
		zombiesLeft =  GameObject.FindGameObjectsWithTag("Zombie1");
		healthText.text = PlayerPrefsManager.GetPlayerHealth().ToString();
		zombiesText.text = zombiesLeft.Length.ToString();
		if (zombiesLeft.Length == 0){
			SceneManager.LoadScene("WinScreen");
		}
		if (Input.GetKeyDown(KeyCode.C) ){
			InvokeRepeating("FireBullets",0.0000001f, 0.2f);
		}else if (Input.GetKeyUp(KeyCode.C) ){
			CancelInvoke();
		}
		if (Input.GetKey(KeyCode.Mouse0)){
			FireBullets();
		}
	}

	void FireBullets()
	{
		GameObject bullets = Instantiate(bulletsToSpawn,bulletsSpawnPoint.transform.position, Quaternion.Euler(0,90,90));
		bullets.GetComponent<Rigidbody>().velocity = bulletsSpawnPoint.transform.forward * -200;
		Destroy(bullets, 3.0f);
	}

	
}
