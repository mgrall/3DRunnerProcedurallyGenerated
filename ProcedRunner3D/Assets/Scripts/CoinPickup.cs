using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {

	public Transform coinEffect;
	public int coinValue = 1;

	void OnTriggerEnter (Collider info) {

		if (info.tag == "Player") {
			DataManagement.dataManagement.coinsCollected += coinValue;
			DataManagement.dataManagement.currentScore += coinValue;

			//coindEffect contains particles and audio
			Transform effect = (Transform) Instantiate (coinEffect, transform.position, transform.rotation);
			Destroy (effect.gameObject, 2);
			Destroy (gameObject);
		}
	}
}
