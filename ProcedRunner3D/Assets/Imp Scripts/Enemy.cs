using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public Rigidbody player;
	public float bounceAmount = 10f;

	public int enemyValue = 1;

	public Transform deathParticles;
	public Transform colliders;

	public Animator enemyAnim;
	Animator centerAnim;

	public AudioClip deathSound;

	void Awake () {
		centerAnim = (Animator) transform.GetComponent ("Animator");
	}

	public void Die () {
		Rigidbody rbb = player.GetComponent<Rigidbody>();
		rbb.velocity = new Vector3(rbb.velocity.x, bounceAmount, rbb.velocity.z); // or:
		//player.GetComponent<Rigidbody>().velocity = new Vector3(player.GetComponent<Rigidbody>().velocity.x, bounceAmount, player.GetComponent<Rigidbody>().velocity.z);
		Transform effect = (Transform) Instantiate (deathParticles, enemyAnim.transform.position, enemyAnim.transform.rotation);
		Destroy (effect.gameObject, 2f);
		enemyAnim.SetTrigger ("Die");
		centerAnim.SetTrigger ("Stop");


		GameMaster.currentScore += enemyValue;
		Destroy (colliders.gameObject);

		GetComponent<AudioSource> ().clip = deathSound;
		GetComponent<AudioSource> ().Play ();

		StartCoroutine ("Despawn");
		//Destroy (gameObject);
	}

	IEnumerator Despawn () {
		yield return new WaitForSeconds (2f);
		Destroy (gameObject);
	}
}
