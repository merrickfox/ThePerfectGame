using UnityEngine;
using System.Collections;

public class DR_GUI : MonoBehaviour 
{	
	public Texture HungerFull;
	public Texture Hunger1;
	public Texture Hunger2;
	public Texture HungerEmpty;
	public Texture HungerFlashing;
	public Texture Journal;
	public Texture ArrowLeft;
	public Texture ArrowRight;
	public Texture BMJournal;
	public Texture BMTracker;

	public bool HungerFlash;

	public bool TrackerOpen;
	public int TrackerPage = 1;

	public int QuestPage = 1;
	public bool JournalOpen;

	public GUISkin journalSkin;
	private Rect journalWindowRect = new Rect(Screen.width/2-500,Screen.height/2-300,1000,600);
	private Rect trackerWindowRect = new Rect(Screen.width/2-500,Screen.height/2-300,1000,600);

	/*public bool TrackAnimal1;
	public bool TrackAnimal2;
	public bool TrackAnimal3;
	public bool TrackAnimal4;
	public bool TrackAnimal5;
	public bool TrackAnimal6;
	public bool TrackAnimal7;
	public bool TrackAnimal8;
	public bool TrackAnimal9;
	public bool TrackAnimal10;
	public bool TrackAnimal11;
	public bool TrackAnimal12;
	public bool TrackAnimal13;
	public bool TrackAnimal14;
	public bool TrackAnimal15;
	public bool TrackAnimal16;
	public bool TrackAnimal17;
	public bool TrackAnimal18;*/

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
		//Debug.Log(PlayerPrefs.GetInt ("Hunger"));

		if(Input.GetKeyDown(KeyCode.J))
		{
			//JournalOpen = true;
			if(JournalOpen == false || TrackerOpen == true)
			{
				TrackerOpen = false;
				JournalOpen = true;
				disableMove();
			}			
			else if(JournalOpen == true)
			{
				JournalOpen = false;
				TrackerOpen = false;
				enableMove();
			}				
		}

		if(Input.GetKeyDown(KeyCode.T))
		{
			//JournalOpen = true;
			if(TrackerOpen == false || JournalOpen == true)
			{
				JournalOpen = false;
				TrackerOpen = true;
				disableMove();
			}			
			else if(TrackerOpen == true)
			{
				TrackerOpen = false;
				JournalOpen = false;
				enableMove();
			}	
		}

		if(Input.GetKeyDown(KeyCode.Escape))
		{
			if(JournalOpen == true || TrackerOpen == true)
			{
				JournalOpen = false;
				TrackerOpen = false;
				enableMove();
			}
		}
	}

	void journalWindowMethod(int windowID)
	{
		GUILayout.BeginArea (new Rect(35, 50, 1000, 600));

		if(QuestPage == 1)
		{
			// Page 1																																							            // ! No text past this point
			if(PlayerPrefs.GetInt ("QuestPart") > 0)
				GUI.Box (new Rect (80, 10, 400, 160), "I had that dream again... blood... screaming... One day these dreams will become truth... one day.");
			if(PlayerPrefs.GetInt ("QuestPart") > 1)
				GUI.Box (new Rect (80, 180, 400, 160), "But first, I need to fill my belly... Nothing to eat here... I'm going to have to catch something tasty to get me going.");
			if(PlayerPrefs.GetInt ("QuestPart") > 2)
				GUI.Box (new Rect (80, 350, 400, 160), "I'll need something to catch my unwitting prey... I should go outside and see what I can find to improvise a trap of some sort.");

			// Page 2
			if(PlayerPrefs.GetInt ("QuestPart") > 3)
				GUI.Box (new Rect (495, 10, 400, 160), "I had that dream again... blood... screaming... One day these dreams will become truth... one day.");
			if(PlayerPrefs.GetInt ("QuestPart") > 4)
				GUI.Box (new Rect (495, 180, 400, 160), "But first, I need to fill my belly... Nothing to eat here... I'm going to have to catch something tasty to get me going.");
			if(PlayerPrefs.GetInt ("QuestPart") > 5)
				GUI.Box (new Rect (495, 350, 400, 160), "I'll need something to catch my unwitting prey... I should go outside and see what I can find to improvise a trap of some sort.");
		}
		else if(QuestPage == 2)
		{
			// Page 3																																							            // ! No text past this point
			if(PlayerPrefs.GetInt ("QuestPart") > 6)
				GUI.Box (new Rect (80, 10, 400, 160), "Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page");
			if(PlayerPrefs.GetInt ("QuestPart") > 7)
				GUI.Box (new Rect (80, 180, 400, 160), "Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3.");
			if(PlayerPrefs.GetInt ("QuestPart") > 8)
				GUI.Box (new Rect (80, 350, 400, 160), "Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3.");
			
			// Page 4
			if(PlayerPrefs.GetInt ("QuestPart") > 9)
				GUI.Box (new Rect (495, 10, 400, 160), "I had that dream again... blood... screaming... One day these dreams will become truth... one day.");
			if(PlayerPrefs.GetInt ("QuestPart") > 10)
				GUI.Box (new Rect (495, 180, 400, 160), "But first, I need to fill my belly... Nothing to eat here... I'm going to have to catch something tasty to get me going.");
			if(PlayerPrefs.GetInt ("QuestPart") > 11)
				GUI.Box (new Rect (495, 350, 400, 160), "I'll need something to catch my unwitting prey... I should go outside and see what I can find to improvise a trap of some sort.");
		}
		else if(QuestPage == 3)
		{
			// Page 5																																							            // ! No text past this point
			GUI.Box (new Rect (80, 10, 400, 160), "I had that dream again... blood... screaming... One day these dreams will become truth... one day.");
			GUI.Box (new Rect (80, 180, 400, 160), "But first, I need to fill my belly... Nothing to eat here... I'm going to have to catch something tasty to get me going.");
			GUI.Box (new Rect (80, 350, 400, 160), "I'll need something to catch my unwitting prey... I should go outside and see what I can find to improvise a trap of some sort.");
			
			// Page 6
			GUI.Box (new Rect (495, 10, 400, 160), "I had that dream again... blood... screaming... One day these dreams will become truth... one day.");
			GUI.Box (new Rect (495, 180, 400, 160), "But first, I need to fill my belly... Nothing to eat here... I'm going to have to catch something tasty to get me going.");
			GUI.Box (new Rect (495, 350, 400, 160), "I'll need something to catch my unwitting prey... I should go outside and see what I can find to improvise a trap of some sort.");
		}
		else if(QuestPage == 4)
		{
			// Page 7																																							            // ! No text past this point
			GUI.Box (new Rect (80, 10, 400, 160), "Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3.");
			GUI.Box (new Rect (80, 180, 400, 160), "Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3.");
			GUI.Box (new Rect (80, 350, 400, 160), "Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3.");
			
			// Page 8
			GUI.Box (new Rect (495, 10, 400, 160), "I had that dream again... blood... screaming... One day these dreams will become truth... one day.");
			GUI.Box (new Rect (495, 180, 400, 160), "But first, I need to fill my belly... Nothing to eat here... I'm going to have to catch something tasty to get me going.");
			GUI.Box (new Rect (495, 350, 400, 160), "I'll need something to catch my unwitting prey... I should go outside and see what I can find to improvise a trap of some sort.");
		}

		if(JournalOpen == true && QuestPage > 1)
		{
			if(GUI.Button(new Rect(30, 230, 40, 40), ArrowLeft))
			{
				QuestPage--;
			}
		}
		if(JournalOpen == true && QuestPage < 4)
		{
			if(GUI.Button(new Rect(900, 230, 40, 40), ArrowRight))
			{
				QuestPage++;
			}
		}

		GUILayout.EndArea();
	}

	void trackerWindowMethod(int windowID)
	{
		GUILayout.BeginArea (new Rect(35, 50, 1000, 600));
			
		if(TrackerPage == 1)
		{
			// Page 1												        // ! No text past this point
			GUI.Box (new Rect (80, 0, 400, 35), "Name       Location       Bait");
			GUI.Box (new Rect (80, 2, 400, 40), "_______________________________");

			if(PlayerPrefs.GetInt ("Animal1") == 0)
				GUI.Box (new Rect (80, 55, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (80, 55, 400, 35), "Animal 1    Stream        Nuts");

			if(PlayerPrefs.GetInt ("Animal2") == 0)
				GUI.Box (new Rect (80, 105, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (80, 105, 400, 35), "Animal 2    Woods          Fish");

			if(PlayerPrefs.GetInt ("Animal3") == 0)
				GUI.Box (new Rect (80, 155, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (80, 155, 400, 35), "Animal 3    Rocks        Mouse");

			if(PlayerPrefs.GetInt ("Animal4") == 0)
				GUI.Box (new Rect (80, 205, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (80, 205, 400, 35), "Animal 4    Rocks        Mouse");

			if(PlayerPrefs.GetInt ("Animal5") == 0)
				GUI.Box (new Rect (80, 255, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (80, 255, 400, 35), "Animal 5    Rocks        Mouse");

			if(PlayerPrefs.GetInt ("Animal6") == 0)
				GUI.Box (new Rect (80, 305, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (80, 305, 400, 35), "Animal 6    Rocks        Mouse");

			if(PlayerPrefs.GetInt ("Animal7") == 0)
				GUI.Box (new Rect (80, 355, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (80, 355, 400, 35), "Animal 7    Rocks        Mouse");

			if(PlayerPrefs.GetInt ("Animal8") == 0)
				GUI.Box (new Rect (80, 405, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (80, 405, 400, 35), "Animal 8    Rocks        Mouse");

			if(PlayerPrefs.GetInt ("Animal9") == 0)
				GUI.Box (new Rect (80, 455, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (80, 455, 400, 35), "Animal 9    Rocks        Mouse");
				
			// Page 2
			GUI.Box (new Rect (495, 0, 400, 35), "Name       Location       Bait");
			GUI.Box (new Rect (495, 2, 400, 40), "_______________________________");

			if(PlayerPrefs.GetInt ("Animal10") == 0)
				GUI.Box (new Rect (495, 55, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (495, 55, 400, 35), "Animal 10    Stream       Nuts");
			
			if(PlayerPrefs.GetInt ("Animal11") == 0)
				GUI.Box (new Rect (495, 105, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (495, 105, 400, 35), "Animal 11    Woods        Fish");
			
			if(PlayerPrefs.GetInt ("Animal12") == 0)
				GUI.Box (new Rect (495, 155, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (495, 155, 400, 35), "Animal 12    Rocks      Mouse");
			
			if(PlayerPrefs.GetInt ("Animal13") == 0)
				GUI.Box (new Rect (495, 205, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (495, 205, 400, 35), "Animal 13    Rocks      Mouse");
			
			if(PlayerPrefs.GetInt ("Animal14") == 0)
				GUI.Box (new Rect (495, 255, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (495, 255, 400, 35), "Animal 14    Rocks      Mouse");
			
			if(PlayerPrefs.GetInt ("Animal15") == 0)
				GUI.Box (new Rect (495, 305, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (495, 305, 400, 35), "Animal 15    Rocks      Mouse");
			
			if(PlayerPrefs.GetInt ("Animal16") == 0)
				GUI.Box (new Rect (495, 355, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (495, 355, 400, 35), "Animal 16    Rocks      Mouse");
			
			if(PlayerPrefs.GetInt ("Animal17") == 0)
				GUI.Box (new Rect (495, 405, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (495, 405, 400, 35), "Animal 17    Rocks      Mouse");
			
			if(PlayerPrefs.GetInt ("Animal18") == 0)
				GUI.Box (new Rect (495, 455, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (495, 455, 400, 35), "Animal 18    Rocks      Mouse");
		}
		else if(TrackerPage == 2)
		{
		// Page 3												        // ! No text past this point
			GUI.Box (new Rect (80, 10, 400, 160), "TrackerPage TrackerPage TrackerPage TrackerPage TrackerPage TrackerPage TrackerPage TrackerPage TrackerPage TrackerPage TrackerPage TrackerPage");
			GUI.Box (new Rect (80, 180, 400, 160), "Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3.");
			GUI.Box (new Rect (80, 350, 400, 160), "Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3. Page 3.");
				
			// Page 4
			GUI.Box (new Rect (495, 10, 400, 160), "I had that dream again... blood... screaming... One day these dreams will become truth... one day.");
			GUI.Box (new Rect (495, 180, 400, 160), "But first, I need to fill my belly... Nothing to eat here... I'm going to have to catch something tasty to get me going.");
			GUI.Box (new Rect (495, 350, 400, 160), "I'll need something to catch my unwitting prey... I should go outside and see what I can find to improvise a trap of some sort.");
		}			

		if(TrackerOpen == true && TrackerPage > 1)
		{
			if(GUI.Button(new Rect(30, 230, 40, 40), ArrowLeft))
			{
				TrackerPage--;
			}
		}
		if(TrackerOpen == true && TrackerPage < 4)
		{
			if(GUI.Button(new Rect(900, 230, 40, 40), ArrowRight))
			{
				TrackerPage++;
			}
		}

		GUILayout.EndArea();
	}

	void OnGUI()
	{
		if(JournalOpen == true)
		{
			GUI.skin=journalSkin;
			journalWindowRect = GUI.Window (0, journalWindowRect, journalWindowMethod, "");
		}
		else if(TrackerOpen == true)
		{
				GUI.skin=journalSkin;
				trackerWindowRect = GUI.Window (0, trackerWindowRect, trackerWindowMethod, "");
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

		/*if(JournalOpen == true && QuestPage > 1)
		{
			if(GUI.Button(new Rect(Screen.width/2-510, Screen.height/2-20, 40, 40), ArrowLeft))
			{
				QuestPage--;
			}
		}
		if(JournalOpen == true && QuestPage < 4)
		{
			if(GUI.Button(new Rect(Screen.width/2+485, Screen.height/2-20, 40, 40), ArrowRight))
			{
				QuestPage++;
			}
		}*/

		/*if(TrackerOpen == true && TrackerPage > 1)
		{
			if(GUI.Button(new Rect(Screen.width/2-510, Screen.height/2-20, 40, 40), ArrowLeft))
			{
				TrackerPage--;
			}
		}
		if(TrackerOpen == true && TrackerPage < 4)
		{
			if(GUI.Button(new Rect(Screen.width/2+485, Screen.height/2-20, 40, 40), ArrowRight))
			{
				TrackerPage++;
			}
		}*/

		if(TrackerOpen == true || JournalOpen == true)
		{
			if(GUI.Button(new Rect(Screen.width/2-320, Screen.height/2-332, 80, 80), BMJournal))
			{
				JournalOpen = true;
				TrackerOpen = false;
			}
			if(GUI.Button(new Rect(Screen.width/2+320, Screen.height/2-332, 80, 80), BMTracker))
			{
				JournalOpen = false;
				TrackerOpen = true;
			}
		}

		//GUI.Label (new Rect(Screen.width/2, Screen.height/2-400, 1500, 2000), "QP = " + QuestPage);
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