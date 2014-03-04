using UnityEngine;
using System.Collections;

public class DR_GUI : MonoBehaviour 
{	
	private Rect journalWindowRect = new Rect(100,100,400,400);

	public Texture HungerFull;
	public Texture Hunger1;
	public Texture Hunger2;
	public Texture HungerEmpty;
	public Texture HungerFlashing;
	public Texture Journal;
	public Texture sfdjlgh;
	public bool HungerFlash;
	public bool JournalOpen;

	public GUISkin journalSkin;

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

		if(Input.GetKeyDown(KeyCode.J))
		{
			//JournalOpen = true;
			if(JournalOpen == false)
			{
				JournalOpen = true;
				disableMove();
			}			
			else if(JournalOpen == true)
			{
				JournalOpen = false;
				enableMove();
			}				
		}

		if(Input.GetKeyDown(KeyCode.Escape))
		{
			if(JournalOpen == true)
			{
				JournalOpen = false;
				enableMove();
			}
		}
	}

	void journalWindowMethod(int windowID)
	{
		GUILayout.BeginArea (new Rect(35, 50, 390, 400));

		GUI.Box (new Rect (50, 50, 100, 50), "This is a test. Testy testy testy wanker");


		GUILayout.EndArea();
	}

	void OnGUI()
	{
		if(JournalOpen == true)
		{
			GUI.skin=journalSkin;
			journalWindowRect = GUI.Window (0, journalWindowRect, journalWindowMethod, "");
		}

		if (PlayerPrefs.GetInt ("Hunger") == 350) 
		{
			StartCoroutine (HungerFlashy ());
			PlayerPrefs.SetInt ("HungerText", 1);
		}
		if (PlayerPrefs.GetInt ("Hunger") == 348)
			StartCoroutine (HungerFlashy ());
		if (PlayerPrefs.GetInt ("Hunger") == 346)
			StartCoroutine (HungerFlashy ());
		if (PlayerPrefs.GetInt ("Hunger") == 344)
			PlayerPrefs.SetInt("HungerText", 0);

		if (PlayerPrefs.GetInt ("Hunger") == 340) 
		{
			StartCoroutine (HungerFlashy ());
			PlayerPrefs.SetInt ("HungerText", 2);
		}
		if (PlayerPrefs.GetInt ("Hunger") == 338)
			StartCoroutine (HungerFlashy ());
		if (PlayerPrefs.GetInt ("Hunger") == 336)
			StartCoroutine (HungerFlashy ());
		if (PlayerPrefs.GetInt ("Hunger") == 334)
			PlayerPrefs.SetInt("HungerText", 0);

		if (PlayerPrefs.GetInt ("Hunger") == 330) 
		{
			StartCoroutine (HungerFlashy ());
			PlayerPrefs.SetInt ("HungerText", 4);
		}
		if (PlayerPrefs.GetInt ("Hunger") == 328)
			StartCoroutine (HungerFlashy ());
		if (PlayerPrefs.GetInt ("Hunger") == 326)
			StartCoroutine (HungerFlashy ());
		if (PlayerPrefs.GetInt ("Hunger") == 324)
			PlayerPrefs.SetInt("HungerText", 0);


		if(PlayerPrefs.GetInt ("Hunger") > 350) //240
			GUI.Label (new Rect(Screen.width/2+700, Screen.height/2-400, 500, 500), HungerFull);
		else if(PlayerPrefs.GetInt ("Hunger") > 340) //120
		{
			GUI.Label (new Rect(Screen.width/2+700, Screen.height/2-400, 500, 500), Hunger2);
		}
		else if(PlayerPrefs.GetInt ("Hunger") > 330)//30
		{
			GUI.Label (new Rect(Screen.width/2+700, Screen.height/2-400, 500, 500), Hunger1);
		}
		else if(PlayerPrefs.GetInt ("Hunger") > 0)
		{
			GUI.Label (new Rect(Screen.width/2+700, Screen.height/2-400, 500, 500), Hunger1);
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
		if(HungerFlash == true)
			GUI.Label (new Rect(Screen.width/2+700, Screen.height/2-400, 500, 500), HungerFlashing);

		/*if(JournalOpen == true)
			GUI.Label (new Rect(Screen.width/2-Journal.width/2, Screen.height/2-Journal.height/2, 1500, 2000), Journal);*/

		//GUI. (new Rect(Screen.width/2-Journal.width/2, Screen.height/2-Journal.height/2, 1500, 2000), Journal);

	}

	IEnumerator HungerFlashy()
	{
		HungerFlash = true;
		yield return new WaitForSeconds(1);
		HungerFlash = false;
	}

	void disableMove()
	{
		gameObject.GetComponent<MouseLook>().enabled = false;
		gameObject.GetComponent<FPSInputController>().enabled = false;
		gameObject.GetComponent<CharacterMotor>().enabled = false;
		transform.Find ("Main Camera").GetComponent<MouseLook>().enabled = false;
	}

	void enableMove()
	{
		gameObject.GetComponent<MouseLook>().enabled = true;
		gameObject.GetComponent<FPSInputController>().enabled = true;
		gameObject.GetComponent<CharacterMotor>().enabled = true;
		transform.Find ("Main Camera").GetComponent<MouseLook>().enabled = true;
	}
}