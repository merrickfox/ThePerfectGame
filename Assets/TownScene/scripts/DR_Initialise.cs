using UnityEngine;
using System.Collections;

public class DR_Initialise : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		PlayerPrefs.SetInt ("Hunger", 360);	//360
		PlayerPrefs.SetInt("HungerText", 0);

		PlayerPrefs.SetInt("QuestPart", 15);

		//Tracking
		PlayerPrefs.SetInt("Animal1", 0); // Mouse
		PlayerPrefs.SetInt("Animal2", 0); // Spider
		PlayerPrefs.SetInt("Animal3", 0); // Squirrel
		PlayerPrefs.SetInt("Animal4", 0); // Skunk
		PlayerPrefs.SetInt("Animal5", 0); // Hedgehog
		PlayerPrefs.SetInt("Animal6", 0); // Owl
		PlayerPrefs.SetInt("Animal7", 0); // Fish
		PlayerPrefs.SetInt("Animal8", 0); // Beaver
		PlayerPrefs.SetInt("Animal9", 0); // Bear
		PlayerPrefs.SetInt("Animal10", 0); // Rabbit
		PlayerPrefs.SetInt("Animal11", 0); // Deer
		PlayerPrefs.SetInt("Animal12", 0); // Chicken
		PlayerPrefs.SetInt("Animal13", 0); // Snake
		PlayerPrefs.SetInt("Animal14", 0); // Eagle
		PlayerPrefs.SetInt("Animal15", 0); // Lizard
		PlayerPrefs.SetInt("Animal16", 0); // Dog
		PlayerPrefs.SetInt("Animal17", 0); // Cat 
		PlayerPrefs.SetInt("Animal18", 0); // Pidgeon
		PlayerPrefs.SetInt("Animal19", 1);
		PlayerPrefs.SetInt("Animal20", 1);
		PlayerPrefs.SetInt("Animal21", 1);
		PlayerPrefs.SetInt("Animal22", 1);
		PlayerPrefs.SetInt("Animal23", 1);
		PlayerPrefs.SetInt("Animal24", 1);
		PlayerPrefs.SetInt("Animal25", 1);
		PlayerPrefs.SetInt("Animal26", 1);
		PlayerPrefs.SetInt("Animal27", 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
