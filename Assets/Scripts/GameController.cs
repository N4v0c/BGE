//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class GameController : MonoBehaviour
//{
//	public int opponents;
////	public float collisionDelay;
//	public Vector3 mobileInit = Vector3.zero;
//	public PlayerController pc;
//	public OpponentController oc;
//	public Scoreboard sb;
//	public bool victory;
////	private float currentDelay;
//
//	void Start ()
//	{
//		victory = false;
//		mobileInit.x = Input.acceleration.x;
//		mobileInit.z = Input.acceleration.z;
////		currentDelay = 0f;
//	}
//	
//	void FixedUpdate ()
//	{
//		Vector3 movement = Vector3.zero;
//
//		//Ball movement on input
//		movement.x = Input.GetAxis ("Horizontal");
//		movement.z = Input.GetAxis ("Vertical");
//
//		//Ball movement on tilt
////		movement.x = Mathf.Max(-1.0f, Mathf.Min(1.0f, 2 * (Input.acceleration.x - mobileInit.x)));
////		movement.z = Mathf.Max(-1.0f, Mathf.Min(1.0f, -2 * (Input.acceleration.z - mobileInit.z)));
//
//		pc.playerForce (movement);
//		oc.opponentForce (movement);
//
//		sb.hitCountText (sb.ballsHit);
//		if (sb.ballsHit < opponents)
//		{
//			sb.displayTime ();
//		}
//		else
//		{
//			victory = true;
//			sb.victory();
//		}
//	}
//}
