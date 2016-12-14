using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CurrentScoreGUI : MonoBehaviour {
	public Text scoreText;

	// Update is called once per frame
	void Update () {
		scoreText.text = "Level Score: " + GameMaster.currentScore;
	}
}
