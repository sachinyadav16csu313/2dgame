
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	[SerializeField]
	Text lifeLabel;
	[SerializeField]
	Text scoreLabel;
	[SerializeField]
	Text gameOverLabel;
	[SerializeField]
	Text highScoreLabel;
	[SerializeField]
	Button restartButton;

	private int _score = 0;
	private int _life = 5;

	public int Score{
		get {return _score;}
		set{ _score = value;
			scoreLabel.text = "SCORE: " + _score;
		}
	}

	public int Life{
		get {return _life;}
		set{ 
			
		_life = value;
		if(_life <= 0) { 
				gameOver();
		}else{
				lifeLabel.text = "LIFE: " + _life;
			}
		}
	}

	private void initialize(){
	
		Score = 0; 
		Life = 5; 

		gameOverLabel.gameObject.SetActive (false);
		highScoreLabel.gameObject.SetActive (false);
		restartButton.gameObject.SetActive (false);

		scoreLabel.gameObject.SetActive (true);
		lifeLabel.gameObject.SetActive (true);
	
	}

	private void gameOver(){
	
		gameOverLabel.gameObject.SetActive (true);
		highScoreLabel.gameObject.SetActive (true);
		restartButton.gameObject.SetActive (true);

		scoreLabel.gameObject.SetActive (false);
		lifeLabel.gameObject.SetActive (false);
	
	}

	void Start () {
		initialize ();
	}
	
	void Update () {
		
	}

	public void RestartBtnClick(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
