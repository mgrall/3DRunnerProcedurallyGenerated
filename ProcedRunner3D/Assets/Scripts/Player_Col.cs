using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Player_Col : MonoBehaviour {

	public GameObject restartUI;
	//this is handled in the coin pickup script
	/* 
	void OnTriggerEnter(Collider trig) {
		if (trig.gameObject.tag == "Coin") {
			//increase score
			// increase coin collection
			// play audio affect
			Destroy(trig.gameObject);
		}
	}
	*/

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "Enemy") {
			PlayerDies ();
		}
	}
	void PlayerDies(){
		DataManagement.dataManagement.SaveData ();
		restartUI.gameObject.SetActive (true);
		GetComponent<Rigidbody> ().isKinematic = true;
		GetComponent<MeshRenderer> ().enabled = false;
		GetComponent<Player_Control> ().enabled = false;
		GetComponent<Player_Move> ().enabled = false;
		//GetComponent<ParticleSystem> ().Play;
		GameInit.gameisPlaying = false;

	}
}
