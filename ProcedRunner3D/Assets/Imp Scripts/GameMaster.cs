using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {
	public static int finalScore = 0;
	public static int currentScore = 0;
	public static bool isRestarting = false;
	public Transform player;

	public Transform musicPrefab;

	public AudioClip GameOverSound;

	public Transform mManager;
	void Start () {
		currentScore = 0;
		if (!GameObject.FindGameObjectWithTag ("MM")) {
			mManager = (Transform) Instantiate (musicPrefab, transform.position, Quaternion.identity);
			mManager.name = musicPrefab.name;
			DontDestroyOnLoad (mManager);
		}
	}
		
	// yield statement returns an IEnumerator, not a void
	// https://docs.unity3d.com/Manual/Coroutines.html
	public IEnumerator RestartLevel () {
		isRestarting = true;
		GetComponent<AudioSource> ().pitch = 1;
		GetComponent<AudioSource> ().clip = GameOverSound;
		GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (GetComponent<AudioSource>().clip.length);

		player.position = CheckPoint.ReachedPoint;
		Rigidbody rbb = player.GetComponent<Rigidbody> ();
		rbb.velocity = new Vector3 (0, 0, 0);
		rbb.angularVelocity = new Vector3 (0, 0, 0);

		Destructible destructible = (Destructible) player.GetComponent("Destructible");
		destructible.Recompose ();
		isRestarting = false;
	}

	public void QuickRestart () {
		isRestarting = true;
		player.position = CheckPoint.ReachedPoint;
		Rigidbody rbb = player.GetComponent<Rigidbody> ();
		rbb.velocity = new Vector3 (0, 0, 0);
		rbb.angularVelocity = new Vector3 (0, 0, 0);
		isRestarting = false;
	}

	public void LoadNextLevel () {
		finalScore += currentScore;
		/*
		if (SceneManager.sceneCount <= SceneManager.GetActiveScene().buildIndex + 1){
			Application.Quit();
		}
		*/
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
