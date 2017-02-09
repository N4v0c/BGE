using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{

	public void ClickExit()
	{
		Debug.Log ("Bye!");
		Application.Quit();
	}
}
