
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

	[SerializeField]
	private float speed = 0.5f; 
	[SerializeField]
	private float upY;
	[SerializeField]
	private float downY;

	private Transform _transform; 
	private Vector2 _currentPos; 

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> (); 
		_currentPos = _transform.position; 
	}
	
	// Update is called once per frame
	void Update () {
		
		_currentPos = _transform.position;

		float userInput = Input.GetAxis ("Vertical");

		if(userInput>0)
		{
			_currentPos += new Vector2(0, speed);
		}

		if(userInput<0)
		{
			_currentPos -= new Vector2(0, speed);
		}

		CheckBounds ();
		_transform.position = _currentPos;
	}

	private void CheckBounds(){

		if (_currentPos.y > upY) {
			_currentPos.y = upY;
		}

		if (_currentPos.y < downY) {
			_currentPos.y = downY;
		}

	}
}