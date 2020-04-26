using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Zombie1Script : MonoBehaviour {

	private Animator anim;
	private GameObject target;
	private int counterHit = 0;
	private float playersDamage, playersHealth, enemysHealth, enemysDamage;
	private AudioSource[] audioSources;
	private AudioSource soundWalk, soundAttack, soundGotHit, soundDeath;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		audioSources = GetComponents<AudioSource>();
		target = GameObject.FindGameObjectWithTag("Player");
		soundWalk = audioSources[0];
		soundAttack = audioSources[1];
		soundGotHit = audioSources[2];
		soundDeath = audioSources[3]; 
		soundWalk.Play();
		PlayerPrefsManager.SetEnemyHealth(100);
		PlayerPrefsManager.SetEnemyDamage(5);
		playersDamage = PlayerPrefsManager.GetPlayerDamage();
		playersHealth = PlayerPrefsManager.GetPlayerHealth();
		enemysHealth = PlayerPrefsManager.GetEnemyHealth();
		enemysDamage = PlayerPrefsManager.GetEnemyDamage();
	}
	
	// Update is called once per frame

	void Update()
	{
		target = GameObject.FindGameObjectWithTag("Player");
		if (!target){
			SceneManager.LoadScene("Menu");
		}
		GetComponent<NavMeshAgent>().destination = target.transform.position;
	}

	void FixedUpdate () {
		
		if (Vector3.Distance(gameObject.transform.position, target.transform.position) > 100){
			soundWalk.volume = 0.15f;
		}else if (Vector3.Distance(gameObject.transform.position, target.transform.position) < 30){
			soundWalk.volume = 1f;
		}else if (Vector3.Distance(gameObject.transform.position, target.transform.position) < 50){
			soundWalk.volume = 0.75f;
		}else if (Vector3.Distance(gameObject.transform.position, target.transform.position) < 75){
			soundWalk.volume = 0.5f;
		}else if (Vector3.Distance(gameObject.transform.position, target.transform.position) < 100){
			soundWalk.volume = 0.3f;
		}
		
	}


	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject.tag == "Bullet"){
			anim.SetTrigger("ZombieGotHit");
			soundGotHit.Play();
			enemysHealth = enemysHealth - playersDamage;
			if (enemysHealth <= 0){
				anim.SetTrigger("ZombieDying");
				soundDeath.Play();
				Destroy(this.gameObject, 3);
			}
		}
		if(other.gameObject.tag == "Player"){
			anim.SetTrigger("ZombieAttack");
			soundAttack.Play();
			playersHealth = playersHealth - enemysDamage;
			PlayerPrefsManager.SetPlayerHealth(playersHealth);
			if(playersHealth <=0){
				Destroy(other.gameObject);
			}
		}
	}

}
