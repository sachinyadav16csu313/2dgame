
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckController : MonoBehaviour {
	
	[SerializeField]
	private float minXspeed = 0.5f;
	[SerializeField]
	private float maxXspeed = 0.10f;
	[SerializeField]
	private float minYspeed = -0.2f;
	[SerializeField]
	private float maxYspeed = 0.2f;


	private Transform _transform; 
	private Vector2 _currentSpeed; 
	private Vector2 _currentPosition;

	void Start () {
		_transform = gameObject.GetComponent<Transform> (); 
		Reset ();
	}

	public void Reset(){
		
		float xSpeed = Random.Range (minXspeed, maxXspeed); 
		float ySpeed = Random.Range (minYspeed, maxYspeed); 

		_currentSpeed = new Vector2 (xSpeed, ySpeed); 

		float y = Random.Range (-4.5f, 4.5f);

		_transform.position = new Vector2 (6.45f + Random.Range (0, 6), y); 
	
	}
	
	// Update is called once per frame
	void Update () {
		_currentPosition = _transform.position;
		_currentPosition -= _currentSpeed; 

		_transform.position = _currentPosition; 

		if (_currentPosition.x <= -6.45) {
			Reset (); 
		}
	}
}
