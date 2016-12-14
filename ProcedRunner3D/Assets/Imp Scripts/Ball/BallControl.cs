
using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	public int rotationSpeed = 100;
	public Rigidbody rb;
	public int jumpHeight = 8;

	public AudioClip hit01;
	public AudioClip hit02;
	public AudioClip hit03;

	private float distToGround;

	void Start () {
		rb = GetComponent<Rigidbody>();
		//Getting the distance from the conter to the ground.
		distToGround = GetComponent<Collider> ().bounds.extents.y;
	}
		
	void Update () {
		//Handle ball rotation.
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;
		rotation *= Time.deltaTime;
		rb.AddRelativeTorque (Vector3.back * rotation);

		//Jumping
		if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)) && isGrounded()) {
			rb.velocity= new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z);
		}
	}

	bool isGrounded(){ //check if we are on the ground. True if we are, else false.
		return Physics.Raycast (transform.position, -Vector3.up, distToGround + 0.1f); 
	}

	void OnCollisionEnter(){
		int theHit = Random.Range (0, 3);

		switch (theHit) {
		case 0:
			GetComponent<AudioSource> ().clip = hit01;
			break;
		case 1:
			GetComponent<AudioSource> ().clip = hit02;
			break;
		case 2:
			GetComponent<AudioSource> ().clip = hit03;
			break;
		}
		GetComponent<AudioSource> ().pitch = Random.Range (0.8f, 1.1f);
		GetComponent<AudioSource> ().Play ();
	}
}
