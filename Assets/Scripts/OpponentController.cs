//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class OpponentController : MonoBehaviour
//{
//	public float ballSpeed;
//	//	public Vector3 mobileInit = Vector3.zero;
//	public GameController gc;
//	public Scoreboard sb;
//
//	private Rigidbody rb;
//	//	private bool victory;
//
//	void Start ()
//	{
//		rb = GetComponent<Rigidbody> ();
//	}
//
//		void FixedUpdate ()
//		{
//	//		Vector3 movement = Vector3.zero;
//	//
//	//		//Ball movement on input
//	//		movement.x = Input.GetAxis ("Horizontal");
//	//		movement.z = Input.GetAxis ("Vertical");
//	//
//	//		//Ball movement on tilt
//	//		//		movement.x = Mathf.Max(-1.0f, Mathf.Min(1.0f, 2 * (Input.acceleration.x - mobileInit.x)));
//	//		//		movement.z = Mathf.Max(-1.0f, Mathf.Min(1.0f, -2 * (Input.acceleration.z - mobileInit.z)));
//	//
//			rb.AddForce (gc.movement * ballSpeed);
//	//
//	//		sb.hitCountText (sb.ballsHit);
//	//		if (sb.ballsHit < sb.opponents)
//	//		{
//	//			sb.displayTime ();
//	//		}
//	//		else
//	//		{
//	//			victory = true;
//	//			sb.victory();
//	//		}
//		}
//
////	public void opponentForce (Vector3 dir)
////	{
//////		orb = GetComponent<Rigidbody> ();
//////		Debug.Log (dir * ballSpeed);
////		orb.AddForce (dir * ballSpeed);
////	}
//
//	void OnCollisionEnter(Collision other)
//	{
//		if (other.gameObject.CompareTag ("Player"))
//		{
//			//			if (Time.time > currentDelay)
//			//			{
//			//				checkUpdate (other.gameObject);
//			//			}
//			checkUpdate ();
//			//			updateBall ();
//		}
//	}
//
//	void checkUpdate()
//	{
//		if (gc.victory == false)
//		{
//			updateBall ();
//			//			setDelay ();
//		} 
//	}
//
//	void updateBall()
//	{
//		if (GetComponent<Renderer> ().material.color == Color.yellow)
//		{
//			sb.ballsHit--;
//			GetComponent<Renderer> ().material.color = Color.red;
//		}
//		else
//		{
//			sb.ballsHit++;
//			GetComponent<Renderer> ().material.color = Color.yellow;
//		}
//		sb.hitCountText (sb.ballsHit);
//	}
//
//	//	void setDelay ()
//	//	{
//	//		currentDelay = Time.time + collisionDelay;
//	//	}
//
//	//	public void RestartGame()
//	//	{
//	//		if (gameObject.tag == "Opponent")
//	//		{
//	//			GetComponent<Renderer> ().material.color = Color.red;
//	//		}
//	//		sb.ballsHit = 0;
//	//		mobileInit.x = Input.acceleration.x;
//	//		mobileInit.z = Input.acceleration.z;
//	//	}
//}
