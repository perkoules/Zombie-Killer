using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapScript : MonoBehaviour {

	public Transform trPlayer;

	void LateUpdate()
	{
		Vector3 newPosition = trPlayer.position;
		newPosition.y = transform.position.y;
		transform.position = newPosition;
	}
}
