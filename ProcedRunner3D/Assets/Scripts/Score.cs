using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// this currently sits on the canvas of Level01
public class Score : MonoBehaviour {

	public Text currentScoreUI;
	public Text highScoreUI;
	
	// Update is called once per frame
	void Update () {
		// update high score if needed
		if (DataManagement.dataManagement.currentScore > DataManagement.dataManagement.highScore) {
			DataManagement.dataManagement.highScore = DataManagement.dataManagement.currentScore;
		}
		// adjust UI score text
		currentScoreUI.text = ("Score " + DataManagement.dataManagement.currentScore.ToString ());
		highScoreUI.text = ("High Score " + DataManagement.dataManagement.highScore.ToString ());
	}

}
