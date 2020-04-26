using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieSpawnerScript : MonoBehaviour {

	public GameObject[] zombiesToSpawn;
	public GameObject zombiesToSpawnStorage;
	private int whichZombieToSpawn = 0;

	// Use this for initialization
	void Start () {
		KeepSpawningWalkingZombies();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
	}

	void KeepSpawningWalkingZombies()
	{
		if(whichZombieToSpawn == 0){
			for (int i=1; i<=10; i++){
				GameObject zombies = Instantiate(zombiesToSpawn[0],ZombiesRandomPosition(i), Quaternion.Euler(0,0,0));
				zombies.transform.SetParent(zombiesToSpawnStorage.transform);
			}
		}		
	}

	Vector3 ZombiesRandomPosition(int i)
	{
		float k =0;
		float x = 30 + 20 * i;
		float y = 51f;
		if (i == 5 || i == 6 || i == 7 || i == 8){
			k = -240;
		}else if (i == 9){
			k = -300;
		}else if (i == 10){
			k = -360;
		}
		float z = -10 + 60 * i + k;
		return new Vector3(x,y,z);
	}


	
}
