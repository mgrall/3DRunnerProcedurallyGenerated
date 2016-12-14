using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	public void LoadToScene (int sceneToLoad){
		SceneManager.LoadScene (sceneToLoad);
	}
}
