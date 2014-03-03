using UnityEngine;
using System.Collections;

public class DR_Initialise : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		PlayerPrefs.SetInt ("Hunger", 360);	//360
		PlayerPrefs.SetInt("HungerText", 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
