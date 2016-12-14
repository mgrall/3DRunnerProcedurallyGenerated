using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour {

	static public Vector3 ReachedPoint;

	void Start () {
		ReachedPoint = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ().position;
		//or: static public Vector3 ReachedPoint = new Vector3 (0, 1, 0);
	}
	void OnTriggerEnter (Collider col){
		if (col.tag == "Player") {
			if (transform.position.x > ReachedPoint.x) {
				
				ReachedPoint = transform.position;
			}
		}
	}
}
