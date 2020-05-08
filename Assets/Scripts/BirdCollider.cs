
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCollider : MonoBehaviour {

	[SerializeField] 
	GameController gameController; 

	[SerializeField]
	GameObject explosion; 

	private AudioSource _coinSound;

	// Use this for initialization
	void Start () {

		
		_coinSound = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D other){
		
		if (other.gameObject.tag.Equals ("Coin")) {
			Debug.Log ("Collision coin\n");
			if (_coinSound != null) {
				_coinSound.Play ();
			}

			gameController.Score+=10; 
			} else if (other.gameObject.tag.Equals ("Enemy")) {
				Debug.Log ("Collision Duck Enemy\n");

			Instantiate (explosion).GetComponent<Transform> ().position = other.gameObject.GetComponent<Transform> ().position; 
				other.gameObject.GetComponent<DuckController> ().Reset (); 
				gameController.Life -= 1; 
			}


		}

}

