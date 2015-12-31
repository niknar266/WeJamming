using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{
	enum State
	{
		INTRO,
		HOW_TO,
		CHARGING,
		AIMING,
		HITTING,
		END,
		NULL
	}

	State currentState;
	State previousState;
	[SerializeField]
	Player
		playerOne, playerTwo;

	int playerThatHit = 0;

	// Use this for initialization
	void Start ()
	{
		currentState = State.CHARGING;
		previousState = State.NULL;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (playerOne.distanceSlider.value + playerTwo.distanceSlider.value >= 0.9f) {
			Debug.Log ("Past");
		}
	}

	public void PlayerHitKnight (int _playerNumber)
	{
		currentState = State.HITTING;
		Debug.Log ("Player " + _playerNumber + " has hit the knight");
	}
}
