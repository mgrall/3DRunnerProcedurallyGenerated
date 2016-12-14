using UnityEngine;
using System.Collections;

public class Player_Move : MonoBehaviour {

	public static int playerSpeed = 10;

	// Update is called once per frame
	void FixedUpdate () {
		gameObject.transform.Translate (Vector3.right * playerSpeed * Time.fixedDeltaTime);
	}
}
