using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillsScript : MonoBehaviour {

	public static int kills;
	Text text;


	void Awake ()
	{
		text = GetComponent <Text> ();
		kills = 0;
	}
		
	void Update ()
	{
		text.text = "Kills: " + kills;
	}
}
