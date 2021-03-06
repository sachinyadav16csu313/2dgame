using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyController : MonoBehaviour {
	[SerializeField] 
	private float speed = 0.2f; 
	[SerializeField]
	private float startX; 
	[SerializeField]
	private float endX;

	private Transform _transform; 
	private Vector2 _currentPos;

	void Start () {
		
		_transform = gameObject.GetComponent<Transform> (); 
		_currentPos = _transform.position;
		Reset();

	}

	void Update () {
		
		_currentPos = _transform.position;
		_currentPos -= new Vector2 (speed, 0);

		if (_currentPos.x < endX){
			Reset ();
		}
		_transform.position = _currentPos;

	}

	private void Reset(){
		_currentPos = new Vector2 (startX, 0);
	}
}
