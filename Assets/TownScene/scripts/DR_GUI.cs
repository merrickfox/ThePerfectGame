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

		/*

		-- Hut -- //
		Mouse
		Spider
		
		-- Woods -- //
		Squirrel
		Skunk
		Hedgehog
		Owl

		-- River -- //
		Fish

		-- Dam -- //f
		Beaver

		-- Cave -- //
		Bear

		-- Field -- //
		Rabbit
		Deer
		Chicken

		-- Rocks --
		Snake
		Eagle
		Lizard

		-- Town --
		Dog
		Cat
		Pidgeon

		*/


		if(TrackerPage == 1)
		{
			// Page 1
			GUI.Box (new Rect (80, 0, 140, 35), "Name");
			GUI.Box (new Rect (220, 0, 120, 35), "Location");
			GUI.Box (new Rect (360, 0, 110, 35), "Bait");
			GUI.Box (new Rect (80, 2, 400, 40), "_______________________________");

			if(PlayerPrefs.GetInt ("Animal1") == 0)
				GUI.Box (new Rect (80, 55, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (80, 55, 140, 35), "Mouse");
				GUI.Box (new Rect (220, 55, 120, 35), "Cabin");
				GUI.Box (new Rect (360, 55, 110, 35), "Nuts");
			}

			if(PlayerPrefs.GetInt ("Animal2") == 0)
				GUI.Box (new Rect (80, 105, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (80, 105, 140, 35), "Spider");
				GUI.Box (new Rect (220, 105, 120, 35), "Cabin");
				GUI.Box (new Rect (360, 105, 110, 35), "Mouse");
			}

			if(PlayerPrefs.GetInt ("Animal3") == 0)
				GUI.Box (new Rect (80, 155, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (80, 155, 140, 35), "Squirrel");
				GUI.Box (new Rect (220, 155, 120, 35), "Woods");
				GUI.Box (new Rect (360, 155, 110, 35), "Nuts");
			}

			if(PlayerPrefs.GetInt ("Animal4") == 0)
				GUI.Box (new Rect (80, 205, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (80, 205, 140, 35), "Skunk");
				GUI.Box (new Rect (220, 205, 120, 35), "Woods");
				GUI.Box (new Rect (360, 205, 110, 35), "Mouse");
			}

			if(PlayerPrefs.GetInt ("Animal5") == 0)
				GUI.Box (new Rect (80, 255, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (80, 255, 140, 35), "Hedgehog");
				GUI.Box (new Rect (220, 255, 120, 35), "Woods");
				GUI.Box (new Rect (360, 255, 110, 35), "Nuts");
			}

			if(PlayerPrefs.GetInt ("Animal6") == 0)
				GUI.Box (new Rect (80, 305, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (80, 305, 140, 35), "Owl");
				GUI.Box (new Rect (220, 305, 120, 35), "Woods");
				GUI.Box (new Rect (360, 305, 110, 35), "Mouse");
			}

			if(PlayerPrefs.GetInt ("Animal7") == 0)
				GUI.Box (new Rect (80, 355, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (80, 355, 140, 35), "Fish");
				GUI.Box (new Rect (220, 355, 120, 35), "River");
				GUI.Box (new Rect (360, 355, 110, 35), "Mouse");
			}

			if(PlayerPrefs.GetInt ("Animal8") == 0)
				GUI.Box (new Rect (80, 405, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (80, 405, 140, 35), "Beaver");
				GUI.Box (new Rect (220, 405, 120, 35), "Dam");
				GUI.Box (new Rect (360, 405, 110, 35), "Mouse");
			}

			if(PlayerPrefs.GetInt ("Animal9") == 0)
				GUI.Box (new Rect (80, 455, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (80, 455, 140, 35), "Bear");
				GUI.Box (new Rect (220, 455, 120, 35), "Cave");
				GUI.Box (new Rect (360, 455, 110, 35), "Fish");
			}
				
			// Page 2
			//GUI.Box (new Rect (495, 0, 400, 35), "Name       Location       Bait");
			GUI.Box (new Rect (495, 0, 140, 35), "Name");
			GUI.Box (new Rect (635, 0, 120, 35), "Location");
			GUI.Box (new Rect (775, 0, 110, 35), "Bait");
			GUI.Box (new Rect (495, 2, 400, 40), "_______________________________");

			if(PlayerPrefs.GetInt ("Animal10") == 0)
				GUI.Box (new Rect (495, 55, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (495, 55, 140, 35), "Rabbit");
				GUI.Box (new Rect (635, 55, 120, 35), "Plains");
				GUI.Box (new Rect (770, 55, 110, 35), "Mouse");
			}
			
			if(PlayerPrefs.GetInt ("Animal11") == 0)
				GUI.Box (new Rect (495, 105, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (495, 105, 140, 35), "Deer");
				GUI.Box (new Rect (635, 105, 120, 35), "Plains");
				GUI.Box (new Rect (770, 105, 110, 35), "Mouse");
			}
			
			if(PlayerPrefs.GetInt ("Animal12") == 0)
				GUI.Box (new Rect (495, 155, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (495, 155, 140, 35), "Chicken");
				GUI.Box (new Rect (635, 155, 120, 35), "Plains");
				GUI.Box (new Rect (770, 155, 110, 35), "Mouse");
			}
			
			if(PlayerPrefs.GetInt ("Animal13") == 0)
				GUI.Box (new Rect (495, 205, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (495, 205, 140, 35), "Snake");
				GUI.Box (new Rect (635, 205, 120, 35), "Rocks");
				GUI.Box (new Rect (770, 205, 110, 35), "Mouse");
			}
			
			if(PlayerPrefs.GetInt ("Animal14") == 0)
				GUI.Box (new Rect (495, 255, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (495, 255, 140, 35), "Eagle");
				GUI.Box (new Rect (635, 255, 120, 35), "Rocks");
				GUI.Box (new Rect (770, 255, 110, 35), "Mouse");
			}
			
			if(PlayerPrefs.GetInt ("Animal15") == 0)
				GUI.Box (new Rect (495, 305, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (495, 305, 140, 35), "Lizard");
				GUI.Box (new Rect (635, 305, 120, 35), "Rocks");
				GUI.Box (new Rect (770, 305, 110, 35), "Spider");
			}
			
			if(PlayerPrefs.GetInt ("Animal16") == 0)
				GUI.Box (new Rect (495, 355, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (495, 355, 140, 35), "Dog");
				GUI.Box (new Rect (635, 355, 120, 35), "Town");
				GUI.Box (new Rect (770, 355, 110, 35), "Cat");
			}
			
			if(PlayerPrefs.GetInt ("Animal17") == 0)
				GUI.Box (new Rect (495, 405, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (495, 405, 140, 35), "Cat");
				GUI.Box (new Rect (635, 405, 120, 35), "Town");
				GUI.Box (new Rect (770, 405, 110, 35), "Mouse");
			}
			
			if(PlayerPrefs.GetInt ("Animal18") == 0)
				GUI.Box (new Rect (495, 455, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (495, 455, 140, 35), "Pidgeon");
				GUI.Box (new Rect (635, 455, 120, 35), "Town");
				GUI.Box (new Rect (770, 455, 110, 35), "Mouse");
			}
		}
		else if(TrackerPage == 2)
		{
			// Page 3
			GUI.Box (new Rect (80, 0, 400, 35), "Name       Location       Bait");
			GUI.Box (new Rect (80, 2, 400, 40), "_______________________________");
			
			if(PlayerPrefs.GetInt ("Animal19") == 0)
				GUI.Box (new Rect (80, 55, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (80, 55, 400, 35), "Raccoon     Stream        Mouse");
			
			if(PlayerPrefs.GetInt ("Animal20") == 0)
				GUI.Box (new Rect (80, 105, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (80, 105, 400, 35), "Crackwhore   Abandoned bldg.   Drugs");
			
			if(PlayerPrefs.GetInt ("Animal21") == 0)
				GUI.Box (new Rect (80, 155, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (80, 155, 400, 35), "Goth      Church        Book");
			
			if(PlayerPrefs.GetInt ("Animal22") == 0)
				GUI.Box (new Rect (80, 205, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (80, 205, 400, 35), "Mayor    Mansion        Sextape");
			
			if(PlayerPrefs.GetInt ("Animal23") == 0)
				GUI.Box (new Rect (80, 255, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (80, 255, 400, 35), "Hobo     Alley        Cash");
			
			if(PlayerPrefs.GetInt ("Animal24") == 0)
				GUI.Box (new Rect (80, 305, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (80, 305, 400, 35), "Drunk     Pub        Beer");
			
			if(PlayerPrefs.GetInt ("Animal25") == 0)
				GUI.Box (new Rect (80, 355, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (80, 355, 400, 35), "Priest    Church        Kid");
			
			if(PlayerPrefs.GetInt ("Animal26") == 0)
				GUI.Box (new Rect (80, 405, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (80, 405, 400, 35), "Kid      Park       Candy");
			
			if(PlayerPrefs.GetInt ("Animal27") == 0)
				GUI.Box (new Rect (80, 455, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (80, 455, 400, 35), "Shopkeeper    Shops       Nuts");
			
			// Page 4
			GUI.Box (new Rect (495, 0, 400, 35), "Name       Location       Bait");
			GUI.Box (new Rect (495, 2, 400, 40), "_______________________________");
			
			if(PlayerPrefs.GetInt ("Animal10") == 0)
				GUI.Box (new Rect (495, 55, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (495, 55, 400, 35), "Middle-class    Woods       Nuts");
			
			if(PlayerPrefs.GetInt ("Animal11") == 0)
				GUI.Box (new Rect (495, 105, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (495, 105, 400, 35), "Upper-class    Upper-cass housing     Fish");
			
			if(PlayerPrefs.GetInt ("Animal12") == 0)
				GUI.Box (new Rect (495, 155, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (495, 155, 400, 35), "Lower-class    Low class housing    Nuts");
			
			if(PlayerPrefs.GetInt ("Animal13") == 0)
				GUI.Box (new Rect (495, 205, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (495, 205, 400, 35), "Owl    Woods      Mouse");
			
			if(PlayerPrefs.GetInt ("Animal14") == 0)
				GUI.Box (new Rect (495, 255, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (495, 255, 400, 35), "Eagle    Rocks      Mouse");
			
			if(PlayerPrefs.GetInt ("Animal15") == 0)
				GUI.Box (new Rect (495, 305, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (495, 305, 400, 35), "Pidgeon    Rocks      Mouse");
			
			if(PlayerPrefs.GetInt ("Animal16") == 0)
				GUI.Box (new Rect (495, 355, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (495, 355, 400, 35), "Dog    Town      Cat");
			
			if(PlayerPrefs.GetInt ("Animal17") == 0)
				GUI.Box (new Rect (495, 405, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (495, 405, 400, 35), "Cat    Town      Mouse");
			
			if(PlayerPrefs.GetInt ("Animal18") == 0)
				GUI.Box (new Rect (495, 455, 400, 35), "?????        ?????           ?????");
			else
				GUI.Box (new Rect (495, 455, 400, 35), "Lizard    Rocks      Spider");
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