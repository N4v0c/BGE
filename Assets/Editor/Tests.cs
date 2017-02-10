using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NUnit.Framework;

public class Tests
{

	float precisionDelta = 0.00001f;

	Vector4 defaultColor = new Vector4 (1.0f, 0.0f, 0.0f, 1.0f);
	Vector4 hitColor = new Vector4 (1.0f, 0.92f, 0.016f, 1.0f);

	[Test]
	public void compareMovementForce()
	{
		float testH = 1.0f;
		float testV = 1.0f;
		float testSpeed = 8.0f;

		Vector3 testMovement = new Vector3 (testH, 0.0f, testV);
		Vector3 testForce = testMovement * testSpeed;

		Assert.AreEqual (testForce.x, testMovement.x * testSpeed, precisionDelta);
		Assert.AreEqual (testForce.y, testMovement.y * testSpeed, precisionDelta);
		Assert.AreEqual (testForce.z, testMovement.z * testSpeed, precisionDelta);
		Debug.Log ("Force: " + testForce);

	}

	[Test]
	public void tiltTest()
	{
		applyForce (0.0f, 0.0f);
		applyForce (-1.0f, 1.0f);
		applyForce (1.0f, -1.0f);
	}

	public void applyForce(float oldPos, float newPos)
	{
		float maxTilt = oldPos + 1.0f;
		float minTilt = oldPos - 1.0f;
		float newTiltH = Mathf.Max(minTilt, Mathf.Min(maxTilt, 2 * (newPos - oldPos)));
		float newTiltV = Mathf.Max(minTilt, Mathf.Min(maxTilt, -2 * (newPos - oldPos)));

		Assert.GreaterOrEqual (newTiltH, minTilt);
		Assert.LessOrEqual (newTiltH, maxTilt);
		Assert.GreaterOrEqual (newTiltV, minTilt);
		Assert.LessOrEqual (newTiltV, maxTilt);
		Debug.Log ("Horizontal: " + (2 * (newPos - oldPos)));
		Debug.Log ("Vertical: " + (-2 * (newPos - oldPos)));
	}

	[Test]
	public void cameraOffsetTest()
	{
		Vector3 testPlayerStartPos = new Vector3 (0.0f, 0.0f, 0.0f);
		Vector3 testCameraStartPos = new Vector3 (0.0f, 10.0f, 0.0f);

		Vector3 testOffset = testCameraStartPos - testPlayerStartPos;
		Vector3 testPlayerNewPos = new Vector3 (1.0f, 0.0f, 1.0f);
		Vector3 testCameraNewPos = testPlayerNewPos + testOffset;

		Assert.AreEqual (testCameraNewPos.x - testCameraStartPos.x, testPlayerNewPos.x + testPlayerStartPos.x, precisionDelta);
		Assert.AreEqual (testCameraNewPos.y - testCameraStartPos.y, testPlayerNewPos.y + testPlayerStartPos.y, precisionDelta);
		Assert.AreEqual (testCameraNewPos.z - testCameraStartPos.z, testPlayerNewPos.z + testPlayerStartPos.z, precisionDelta);
	}

	[Test]
	public void updateTest()
	{
		Vector4 falseColor = new Vector4 (0.0f, 0.0f, 0.1f, 1.0f);

		ballUpdateTest(hitColor, 0);
		ballUpdateTest(falseColor, 0);
		ballUpdateTest(defaultColor, 0);
	}

	public void ballUpdateTest (Vector4 testColor, int testHits)
	{
		Vector4 newColor;
		if (testColor == defaultColor)
		{
			testHits--;
			newColor = hitColor;
		}
		else
		{
			testHits++;
			newColor = defaultColor;
		}
		Assert.IsNotNull (newColor);
		Assert.AreNotSame (newColor, testColor);
		Assert.GreaterOrEqual (testHits, 0);
	}
}
