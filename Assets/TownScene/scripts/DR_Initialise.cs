using UnityEngine;
using System.Collections;

public class DR_Initialise : MonoBehaviour 
{
	void Start () 
	{
		PlayerPrefs.SetInt ("Resource", 0);
		PlayerPrefs.SetInt ("Bait", 0);
		PlayerPrefs.SetInt ("Caught", 0);
		PlayerPrefs.SetInt ("TrapWait", 0);
		PlayerPrefs.SetInt ("Hunger", 360);	//360
		PlayerPrefs.SetInt("HungerText", 0);
		PlayerPrefs.SetInt("QuestPart", 0);

		//Tracking
		PlayerPrefs.SetInt("Animal1", 0); // Mouse
		PlayerPrefs.SetInt("Animal2", 0); // Spider
		PlayerPrefs.SetInt("Animal3", 0); // Squirrel
		PlayerPrefs.SetInt("Animal4", 0); // Skunk
		PlayerPrefs.SetInt("Animal5", 0); // Hedgehog
		PlayerPrefs.SetInt("Animal6", 0); // Owl
		PlayerPrefs.SetInt("Animal7", 0); // Raccoon
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
		PlayerPrefs.SetInt("Animal19", 0); // Druggy
		PlayerPrefs.SetInt("Animal20", 0); // Whore
		PlayerPrefs.SetInt("Animal21", 0); // Drunk
		PlayerPrefs.SetInt("Animal22", 0); // Homeless
		PlayerPrefs.SetInt("Animal23", 0); // Binman
		PlayerPrefs.SetInt("Animal24", 0); // Pharmacist
		PlayerPrefs.SetInt("Animal25", 0); // Goth
		PlayerPrefs.SetInt("Animal26", 0); // Priest
		PlayerPrefs.SetInt("Animal27", 0); // Banker
		PlayerPrefs.SetInt("Animal28", 0); // Mayor
	}
}
