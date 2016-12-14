using UnityEngine;
using System.Collections;

public class DieOnHit : MonoBehaviour {

	void OnTriggerEnter () {
		Enemy enemy = transform.GetComponentInParent<Enemy> ();
		enemy.Die ();
	}

}
