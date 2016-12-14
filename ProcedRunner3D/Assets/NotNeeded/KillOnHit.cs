using UnityEngine;
using System.Collections;

public class KillOnHit : MonoBehaviour {

	public GameMaster gameMaster;

	void OnTriggerEnter(Collider colInfo){
		if (!GameMaster.isRestarting){
			if (colInfo.tag == "Player") {
				Destructible destructible = (Destructible) colInfo.GetComponent("Destructible");
				destructible.Destruct ();
			}
			gameMaster.StartCoroutine ("RestartLevel");
		}
	}
}
