using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
	public float ballSpeed;
//	public int opponents;
//	public float collisionDelay;
	public Vector3 mobileInit = Vector3.zero;
//	public GameController gc;
	public Scoreboard sb;

	private Rigidbody rb;
	private bool victory;
//	private float currentDelay;

	void Start ()
	{
		victory = false;
		rb = GetComponent<Rigidbody> ();
		mobileInit.x = Input.acceleration.x;
		mobileInit.z = Input.acceleration.z;
//		currentDelay = 0f;
	}
	
	void FixedUpdate ()
	{
		Vector3 movement = Vector3.zero;

		//Ball movement on input
//		movement.x = Input.GetAxis ("Horizontal");
//		movement.z = Input.GetAxis ("Vertical");

		//Ball movement on tilt
		movement.x = Mathf.Max(mobileInit.x - 1.0f, Mathf.Min(mobileInit.x + 1.0f, 2 * (Input.acceleration.x - mobileInit.x)));
		movement.z = Mathf.Max(mobileInit.z - 1.0f, Mathf.Min(mobileInit.z + 1.0f, -2 * (Input.acceleration.z - mobileInit.z)));

		rb.AddForce (movement * ballSpeed);

		sb.hitCountText (sb.ballsHit);
		if (sb.ballsHit < sb.opponents)
		{
			sb.displayTime ();
		}
		else
		{
			victory = true;
			sb.victory();
		}
	}

//	public void addForce (Vector3 dir)
//	{
//		rb.AddForce (dir * ballSpeed);
//	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag ("Player"))
		{
//			if (Time.time > currentDelay)
//			{
//				checkUpdate (other.gameObject);
//			}
			checkUpdate ();
//			updateBall ();
		}
	}

	void checkUpdate()
	{
		if (victory == false)
		{
			updateBall ();
//			setDelay ();
		} 
	}

	void updateBall()
	{
		if (GetComponent<Renderer> ().material.color == Color.yellow)
		{
			sb.ballsHit--;
			GetComponent<Renderer> ().material.color = Color.red;
		}
		else
		{
			sb.ballsHit++;
			GetComponent<Renderer> ().material.color = Color.yellow;
		}
		sb.hitCountText (sb.ballsHit);
	}

//	void setDelay ()
//	{
//		currentDelay = Time.time + collisionDelay;
//	}

//	public void RestartGame()
//	{
//		if (gameObject.tag == "Opponent")
//		{
//			GetComponent<Renderer> ().material.color = Color.red;
//		}
//		sb.ballsHit = 0;
//		mobileInit.x = Input.acceleration.x;
//		mobileInit.z = Input.acceleration.z;
//	}
}
