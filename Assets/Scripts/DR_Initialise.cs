using UnityEngine;
using System.Collections;

public class DR_Initialise : MonoBehaviour 
{
	void Start () 
	{
		if(PlayerPrefs.GetInt ("Quest") == 0)
			PlayerPrefs.SetInt ("Quest", 1);

		PlayerPrefs.SetInt ("LevelSelect", 2);
		PlayerPrefs.SetInt("d", 0);
	}
}
