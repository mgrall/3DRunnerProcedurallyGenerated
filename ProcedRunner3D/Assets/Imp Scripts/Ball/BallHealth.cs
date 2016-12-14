using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BallHealth : MonoBehaviour {

	public int maxFallDistance = -10;

	public GameMaster gameMaster;

	void Update () {

		if (transform.position.y <= maxFallDistance) {
			//EndLevel behaviour
			if (SceneManager.sceneCountInBuildSettings <= (int)SceneManager.GetActiveScene ().buildIndex + 1) {
				GameMaster.finalScore = 0;
				SceneManager.LoadScene (0);
				//Application.Quit ();
				//Debug.Log ("Quitting game...");
			} //MainMenu behaviour
			else if (GameMaster.isRestarting == false && SceneManager.GetActiveScene ().buildIndex == 0) {
				gameMaster.QuickRestart ();
			}//Standard behaviour
			else if (GameMaster.isRestarting == false){
				gameMaster.StartCoroutine("RestartLevel");
			}
		}

		if ((Input.GetKeyDown (KeyCode.R)) && !(SceneManager.sceneCountInBuildSettings <= (int)SceneManager.GetActiveScene ().buildIndex + 1)) {
			gameMaster.QuickRestart ();
		}

	}
}