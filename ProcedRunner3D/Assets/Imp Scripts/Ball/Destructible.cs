using UnityEngine;
using System.Collections;

public class Destructible : MonoBehaviour {

	public Rigidbody ballRigidbody;
	public SphereCollider ballCollider;
	public Transform piecesParent;
	public Transform piecesPrefab;
	public GameObject wholeBall;

	public void Destruct () {
		ballRigidbody.isKinematic = true;
		ballCollider.enabled = false;
		Transform clone = (Transform) Instantiate (piecesPrefab, piecesParent.position, piecesParent.rotation);
		Destroy (clone.gameObject, 5f);
		//??
		//clone.parent = piecesParent;
		wholeBall.SetActive (false);
	}


	public void Recompose () {
		ballRigidbody.isKinematic = false;
		ballCollider.enabled = true;
		wholeBall.SetActive (true);
	}
}
