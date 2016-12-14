using UnityEngine;
using System.Collections;

public class MusicPre : MonoBehaviour {


	void OnLevelWasLoaded () {

		//gameMaster.mManager = this.transform;
		GameObject gameMaster = GameObject.Find("_GM");
		GameMaster gm = gameMaster.GetComponent<GameMaster>();
		gm.mManager = this.transform;
	}
	// Use this for initialization
	void Start () {

	 
	}
	
	// Update is called once per frame
	void Update () {
	}
}
