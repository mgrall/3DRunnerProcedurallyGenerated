using UnityEngine;
using System.Collections;

public class GameInit : MonoBehaviour {
	public static bool gameisPlaying;

	// Use this for initialization
	void Start () {
		gameisPlaying = true;
		DataManagement.dataManagement.currentScore = 0;
		DataManagement.dataManagement.LoadData ();
	}
	

}
