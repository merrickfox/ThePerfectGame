using UnityEngine;
using System.Collections;

public class DR_Initialise : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		PlayerPrefs.SetInt ("Hunger", 360);	//360
		PlayerPrefs.SetInt("HungerText", 0);

		PlayerPrefs.SetInt("QuestPart", 8);

		//Tracking
		PlayerPrefs.SetInt("Animal1", 1);
		PlayerPrefs.SetInt("Animal2", 0);
		PlayerPrefs.SetInt("Animal3", 1);
		PlayerPrefs.SetInt("Animal4", 0);
		PlayerPrefs.SetInt("Animal5", 0);
		PlayerPrefs.SetInt("Animal6", 1);
		PlayerPrefs.SetInt("Animal7", 0);
		PlayerPrefs.SetInt("Animal8", 0);
		PlayerPrefs.SetInt("Animal9", 1);
		PlayerPrefs.SetInt("Animal10", 0);
		PlayerPrefs.SetInt("Animal11", 0);
		PlayerPrefs.SetInt("Animal12", 1);
		PlayerPrefs.SetInt("Animal13", 1);
		PlayerPrefs.SetInt("Animal14", 1);
		PlayerPrefs.SetInt("Animal15", 0);
		PlayerPrefs.SetInt("Animal16", 0);
		PlayerPrefs.SetInt("Animal17", 1);
		PlayerPrefs.SetInt("Animal18", 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
