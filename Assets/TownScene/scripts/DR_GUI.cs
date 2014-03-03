using UnityEngine;
using System.Collections;

public class DR_GUI : MonoBehaviour 
{	
	public Texture HungerFull;
	public Texture Hunger1;
	public Texture Hunger2;
	public Texture HungerEmpty;

	void Start () 
	{		
		InvokeRepeating ("HealthDecrease", 0, 1);
	}
	
	void HealthDecrease () 
	{		
		PlayerPrefs.SetInt ("Hunger", PlayerPrefs.GetInt ("Hunger") -1);
	}
	
	void Update () 
	{		
		Debug.Log(PlayerPrefs.GetInt ("Hunger"));
	}

	void OnGUI()
	{
		if(PlayerPrefs.GetInt ("Hunger") > 240) //240
			GUI.Label (new Rect(Screen.width/2+700, Screen.height/2-400, 500, 500), HungerFull);
		else if(PlayerPrefs.GetInt ("Hunger") > 120) //120
		{
			GUI.Label (new Rect(Screen.width/2+700, Screen.height/2-400, 500, 500), Hunger2);
			StartCoroutine(HungerText());
		}
		else if(PlayerPrefs.GetInt ("Hunger") > 30)//30
		{
			GUI.Label (new Rect(Screen.width/2+700, Screen.height/2-400, 500, 500), Hunger1);
			StartCoroutine(HungerText2());
		}
		else if(PlayerPrefs.GetInt ("Hunger") > 0)
		{
			GUI.Label (new Rect(Screen.width/2+700, Screen.height/2-400, 500, 500), Hunger1);
			PlayerPrefs.SetInt ("HungerText",4);
		}
		else if(PlayerPrefs.GetInt ("Hunger") < 1)
		{
			GUI.Label (new Rect(Screen.width/2+700, Screen.height/2-400, 500, 500), HungerEmpty);
			PlayerPrefs.SetInt("HungerText", 3);
		}

		if(PlayerPrefs.GetInt("HungerText") == 1)
		{
			GUI.Label (new Rect(Screen.width/2+670, Screen.height/2-350, 500, 500), "You start to feel hungry"); //x = /2-50, 7 = /2
		}
		if(PlayerPrefs.GetInt("HungerText") == 2)
		{
			GUI.Label (new Rect(Screen.width/2+620, Screen.height/2-350, 500, 500), "You are hungry. You need to eat soon"); //x = /2-100, 7 = /2
		}
		if(PlayerPrefs.GetInt("HungerText") == 3)
		{
			GUI.Label (new Rect(Screen.width/2+670, Screen.height/2-350, 500, 500), "You starved to death!"); //x = /2-50, 7 = /2
		}
		if(PlayerPrefs.GetInt("HungerText") == 4)
		{
			GUI.Label (new Rect(Screen.width/2+670, Screen.height/2-350, 500, 500), "You're about to starve!"); //x = /2-50, 7 = /2
		}
		//GUI.Label (new Rect(Screen.width/2, Screen.height/2+50, 500, 500), PlayerPrefs.GetInt ("HungerText").ToString());
	}

	IEnumerator HungerText()
	{
		PlayerPrefs.SetInt("HungerText", 1);
		yield return new WaitForSeconds(3);
		PlayerPrefs.SetInt("HungerText", 0);
		Debug.Log("hello");
	}
	IEnumerator HungerText2()
	{
		PlayerPrefs.SetInt("HungerText", 2);
		yield return new WaitForSeconds(3);
		PlayerPrefs.SetInt("HungerText", 0);
		Debug.Log("hello2");
	}
}