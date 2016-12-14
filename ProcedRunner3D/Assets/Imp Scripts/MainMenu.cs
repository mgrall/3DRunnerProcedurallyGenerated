using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class MainMenu : MonoBehaviour {
	public GameMaster gameMaster;
	public AudioSource music;
	/*
	void Start(){
		if (!GameObject.FindGameObjectWithTag ("MM")) {
			GetComponent<AudioSource> ().Play ();
		}

	}
	*/


	public void QuitGame () {
		Debug.Log ("Game is exiting...");
		Application.Quit ();
	}

	public void StartGame(string level){
		//Application.LoadLevel (level);
		//SceneManager.LoadScene ("Level01");
		SceneManager.LoadScene (level);
	}

	public void SetGameVolume (float vol){
		//music.volume = vol;
		gameMaster.mManager.GetComponent<AudioSource>().volume = vol;
	}

}
