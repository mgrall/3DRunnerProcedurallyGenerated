using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public Transform target;
	public float distance = -10f;
	public float lift = 1.5f;

	void LateUpdate () {
		
		//position of the object this script is targeting (Main Camera)
		transform.position = target.position + (new Vector3(0, lift, distance));

		transform.LookAt (target);
	}
}
