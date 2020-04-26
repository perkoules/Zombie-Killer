using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManagerScript : MonoBehaviour {

	public void LoadLevelByName(string name)
	{
		SceneManager.LoadScene(name);
	}

	public void QuitRequest(){
		Application.Quit();
	}
}
