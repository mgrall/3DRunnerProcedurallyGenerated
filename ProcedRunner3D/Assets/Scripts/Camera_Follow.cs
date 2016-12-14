using UnityEngine;
using System.Collections;


// combine x and y follow.
public class Camera_Follow : MonoBehaviour {

	private GameObject player;
	public float cameraSpeed = 5.0f;
	public float xOffset = 8.0f;
	public float vertLerp = 20.0f;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		// x pos follow
		Vector3 camPos = transform.position;
		camPos.x = player.transform.position.x + xOffset;
		transform.position = Vector3.Lerp (transform.position, camPos, 3 * Time.fixedDeltaTime);

		//y pos follow
		camPos.y = player.transform.position.y + 2;
		transform.position = Vector3.Lerp (transform.position, camPos, vertLerp * Time.fixedDeltaTime);
	}
}
