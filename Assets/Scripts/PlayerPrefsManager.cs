using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {


	
	const string PLAYER_DAMAGE = "player_damage";
	const string PLAYER_HEALTH = "player_health";
	const string ENEMY_DAMAGE = "enemy_damage";
	const string ENEMY_HEALTH = "enemy_health";

	public static void SetPlayerDamage(float damage){
		PlayerPrefs.SetFloat (PLAYER_DAMAGE, damage);
	}

	public static float GetPlayerDamage (){
		return PlayerPrefs.GetFloat (PLAYER_DAMAGE);
	}

	public static void SetPlayerHealth(float health){
		PlayerPrefs.SetFloat (PLAYER_HEALTH, health);
	}

	public static float GetPlayerHealth (){
		return PlayerPrefs.GetFloat (PLAYER_HEALTH);
	}

	public static void SetEnemyDamage(float damage){
		PlayerPrefs.SetFloat (ENEMY_DAMAGE, damage);
	}

	public static float GetEnemyDamage (){
		return PlayerPrefs.GetFloat (ENEMY_DAMAGE);
	}
	
	public static void SetEnemyHealth(float health){
		PlayerPrefs.SetFloat (ENEMY_HEALTH, health);
	}

	public static float GetEnemyHealth (){
		return PlayerPrefs.GetFloat (ENEMY_HEALTH);
	}

}
