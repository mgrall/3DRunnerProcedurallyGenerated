using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// move Player_Control.maxJetPackFuel to a local variable.
public class FuelBar : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		adjustFuelBar ();
	}

	void adjustFuelBar (){

		if (Player_Control.jetPackFuel > 0) {
			// normalize current jetPackFuel to a scale if 0 - 1
			float normalizedFuel = (Player_Control.jetPackFuel - 0) / (Player_Control.maxJetPackFuel - 0);

			gameObject.transform.localScale = new Vector3 (normalizedFuel, 1, 1);
		}

	}
}
