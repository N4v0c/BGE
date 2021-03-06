using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
	public int opponents;
	public Text hitCount;
	public Text currentTime;
	public Text victoryText;
	public Text finalTime;
	public int ballsHit;
//	private float currentDelay;

	void Start ()
	{
		ballsHit = 0;
		victoryText.text = "";
		finalTime.text = "";
	}

//	void setDelay ()
//	{
//		currentDelay = Time.time + collisionDelay;
//	}

	public void displayTime()
	{
		currentTime.text = "Time: " + Time.time.ToString ("F2");
	}

	public void hitCountText(int hits)
	{
		hitCount.text = "Balls Hit: " + hits.ToString ();
	}

	public void victory()
	{
		victoryText.text = "A WINNER IS YOU!";
		finalTime.text = currentTime.text;
	}
}
