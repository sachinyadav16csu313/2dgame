
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

	[SerializeField]
	private float speed = 0.2f;
	[SerializeField]
	private float startY = 4.5f;
	[SerializeField]
	private float endY = -4.5f;
	[SerializeField]
	private float startX;
	[SerializeField]
	private float endX;


	private Transform _transform; 
	private Vector2 _currentPos;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> (); 
		_currentPos = _transform.position;
		Reset();
	}
	
	// Update is called once per frame
	void Update () {
		_currentPos = _transform.position; 
		_currentPos -= new Vector2 (speed, 0);

		if (_currentPos.x < endX){
			Reset ();
		}
		_transform.position = _currentPos;
	}

	private void Reset(){
		float y = Random.Range (startY, endY); 
		float dx = Random.Range (-7, 7); 
		_currentPos = new Vector2 (startX + dx, y); 
	
	}

}
