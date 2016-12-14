using UnityEngine;
using System.Collections;

public class Player_Control : MonoBehaviour {
	public static float maxJetPackFuel = 1.5f;
	public static float jetPackFuel;
	public float jetPackForce = 10.0f;
	private Rigidbody rb;

	void Awake(){
		rb = GetComponent<Rigidbody> ();
	}
	void Start(){
		jetPackFuel = maxJetPackFuel;
	}

#if UNITY_STANDALONE

	void Update () {
		if (Input.GetButton ("Jump") && jetPackFuel > 0.0f) {
			BoostUp ();
		}

	}
#endif

#if UNITY_ANDROID
	void Update (){
		if ((Input.touchCount > 0) && jetPackFuel > 0.0f) {
			BoostUp ();
		}
	}
#endif

	void BoostUp(){
		jetPackFuel = Mathf.MoveTowards (jetPackFuel, 0, Time.fixedDeltaTime);
		rb.AddForce (new Vector3 (0, jetPackForce));
	}

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "Ground") {
			jetPackFuel = maxJetPackFuel;
		}
	}
}
