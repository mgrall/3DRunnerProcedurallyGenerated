using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

	private float timeTillDestroy = 10.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeTillDestroy -= Time.deltaTime;
		if (timeTillDestroy < 0.01 && GameInit.gameisPlaying == true) {
			Destroy (gameObject);
		}

	}
}
