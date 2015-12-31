using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour
{
	[SerializeField]
	float
		currentSpeed = 0.0f, currentDistance = 0.0f, speedIncement = 0.0f, speedDecrement = 0.0f, topSpeed = 0.0f;
	[SerializeField]
	GameController
		cont;
	[SerializeField]
	int
		playerNumber = 0;
	public
	Slider
		powerSlider, distanceSlider;
	string lastPressed = "";

	void Update ()
	{
		currentSpeed = Mathf.Clamp (currentSpeed - (speedDecrement * Time.deltaTime), 0, topSpeed);
		distanceSlider.value += (currentSpeed / topSpeed) / 100;
		powerSlider.value = (currentSpeed / topSpeed);
	}

	public void RunningButton (string _buttonName)
	{
		if (lastPressed != _buttonName) {
			currentSpeed = Mathf.Clamp (currentSpeed + speedIncement, 0, topSpeed);
			Debug.Log ("Step");
		} else {
			Debug.Log ("Missed");
		}
		lastPressed = _buttonName;
	}

	public void HitKnight ()
	{
		cont.PlayerHitKnight (playerNumber);
	}
}
