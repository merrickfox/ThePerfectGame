using UnityEngine;
using System.Collections;

public class DR_GUI : MonoBehaviour 
{	
	public GameObject Player;
	public GameObject TutWall;
	public GameObject Tut2Walls;
	GameObject[] Traps;

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
	public Texture Paper;
	public Texture TutHeader;
	public Texture black;
	public Texture JournalTexture;
	public Texture TrackerTexture;
	public Texture blackTexture;

	public bool HungerFlash;

	public bool TrackerOpen;
	public int TrackerPage = 1;

	public int QuestPage = 1;
	public bool JournalOpen;

	public int TutorialInt;
	public int Tutorial;

	public int TutorialOrder;
	public int TutorialOrder2;

	public int WakeupMove;

	public bool wakingup;

	public float topBlack;
	public float botBlack;

	public int a;
	public int b;
	public int c;
	public int ToDoList;

	public int JournalEntryPing;
	public int TrackerEntryPing;

	public int Trap1;
	public int Trap2;
	public int Trap3;

	public GUISkin journalSkin;
	public GUISkin paperGUI;
	private Rect journalWindowRect = new Rect(Screen.width/2-500,Screen.height/2-300,1000,600);
	private Rect trackerWindowRect = new Rect(Screen.width/2-500,Screen.height/2-300,1000,600);
	private Rect tutorialWindowRect = new Rect(Screen.width/2-300,Screen.height/2-400,600,800);

	void Start () 
	{		
		InvokeRepeating ("HealthDecrease", 0, 1);
		if (PlayerPrefs.GetInt ("GameStart") == 0)
		{
			StartCoroutine(Wakeup());
			topBlack = 0f;
			botBlack = Screen.height/2f;
			PlayerPrefs.SetInt ("GameStart", 1);
		}
	}
	
	void HealthDecrease () 
	{		
		PlayerPrefs.SetInt ("Hunger", PlayerPrefs.GetInt ("Hunger") -1);
	}
	
	void Update () 
	{
		if(wakingup == true)
		{
			topBlack -= 0.8f;
			botBlack += 0.8f;
		}
		if(wakingup == false)
		{
			topBlack = 1000f;
			botBlack = 1000f;			
		}

		if(Trap1 == 1) // tracks
		{
			if(PlayerPrefs.GetInt ("TutorialOrder") == 0)
				PlayerPrefs.SetInt("TutorialOrder", 1); 
			else if(PlayerPrefs.GetInt ("TutorialOrder") == 2)
				PlayerPrefs.SetInt("TutorialOrder2", 3);  
			else if(PlayerPrefs.GetInt ("TutorialOrder") == 3)
				PlayerPrefs.SetInt("TutorialOrder2", 5);  
		}
		if(Trap2 == 1) // parts
		{
			if(PlayerPrefs.GetInt ("TutorialOrder") == 0)
				PlayerPrefs.SetInt("TutorialOrder", 2); 
			else if(PlayerPrefs.GetInt ("TutorialOrder") == 1)
				PlayerPrefs.SetInt("TutorialOrder2", 1);
			else if(PlayerPrefs.GetInt ("TutorialOrder") == 3)
				PlayerPrefs.SetInt("TutorialOrder2", 6);
		}
		if(Trap3 == 1) // trap
		{
			if(PlayerPrefs.GetInt ("TutorialOrder") == 0)
				PlayerPrefs.SetInt("TutorialOrder", 3);
			else if(PlayerPrefs.GetInt ("TutorialOrder") == 1)
				PlayerPrefs.SetInt("TutorialOrder2", 2);
			else if(PlayerPrefs.GetInt ("TutorialOrder") == 2)
				PlayerPrefs.SetInt("TutorialOrder2", 4);
		}

		if(Tutorial > 0)
		{
			TrackerOpen = false;
			JournalOpen = false;
			disableMove();
		}

		if(Input.GetKeyDown(KeyCode.P))
		{
			Application.LoadLevel ("DanForestTut");
		}

		if(Input.GetKeyDown(KeyCode.J))
		{
			Tutorial = 0;

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
			Tutorial = 0;

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
			if(JournalOpen == true || TrackerOpen == true || Tutorial > 0)
			{
				JournalOpen = false;
				TrackerOpen = false;
				Tutorial = 0;
				enableMove();
			}
		}

		if(PlayerPrefs.GetInt("c") >0)
		{
			Destroy(TutWall);
		}

		if(Input.GetKeyDown(KeyCode.E))
		{
			if(TutorialInt == 1)
			{
				Tutorial = 1;
				if(PlayerPrefs.GetInt("c") < 1)
				{
					PlayerPrefs.SetInt("QuestPart", 3);
					StartCoroutine(JournalEntry());
					PlayerPrefs.SetInt ("c", PlayerPrefs.GetInt("c") +1);
				}
			}
			else if(TutorialInt == 2)
				Tutorial = 2;
			else if(TutorialInt == 3)
				Tutorial = 3;
			else if(TutorialInt == 4)
			{
				Tutorial = 4;
				if(PlayerPrefs.GetInt("b") < 3)
				{
					Trap3 = 1;
					PlayerPrefs.SetInt("QuestPart", 5);
					StartCoroutine(JournalEntry());
					PlayerPrefs.SetInt ("b", PlayerPrefs.GetInt("b") +1);
				}
			}
			else if(TutorialInt == 5)
			{
				if(PlayerPrefs.GetInt("b") < 3)
				{
					Trap1 = 1;
					PlayerPrefs.SetInt("QuestPart", 5);
					StartCoroutine(JournalEntry());
					PlayerPrefs.SetInt ("b", PlayerPrefs.GetInt("b") +1);
				}
			}
			else if(TutorialInt == 6)
			{
				StartCoroutine(Wakeup());
				Traps = GameObject.FindGameObjectsWithTag("Trap");
				for(int j = 0; j < Traps.Length; j++)
				{
					if(Traps[j] != null)
					{
						if (Traps[j].gameObject.GetComponent<TrapSettings>().GetBait() > 0)
							Traps[j].gameObject.GetComponent<TrapSettings>().SetEmpty(false);
					}
				}
			}
			else if(TutorialInt == 7)
			{
				StartCoroutine(Wakeup());
			}
			else if(TutorialInt == 9)
			{
				if(PlayerPrefs.GetInt("b") < 3)
				{
					Trap2 = 1;
					PlayerPrefs.SetInt("QuestPart", 5);
					StartCoroutine(JournalEntry());
					PlayerPrefs.SetInt ("b", PlayerPrefs.GetInt("b") +1);
				}
			}
			else if(TutorialInt == 10)
			{
				StartCoroutine(Wakeup2());
				Traps = GameObject.FindGameObjectsWithTag("Trap");
				for(int j = 0; j < Traps.Length; j++)
				{
					if(Traps[j] != null)
					{
						if (Traps[j].gameObject.GetComponent<TrapSettings>().GetBait() > 0)
							Traps[j].gameObject.GetComponent<TrapSettings>().SetEmpty(false);
					}
				}
			}
			else if(TutorialInt == 11)
			{
				if(PlayerPrefs.GetInt("d") < 1)
				{
					PlayerPrefs.SetInt("QuestPart", 11);
					StartCoroutine(JournalEntry());
					PlayerPrefs.SetInt ("d", PlayerPrefs.GetInt("d") +1);
				}
			}
		}

		if(PlayerPrefs.GetInt ("ResourceGet") == 1)
		{
			PlayerPrefs.SetInt("QuestPart", 6);
			StartCoroutine(JournalEntry());
		}
		if(PlayerPrefs.GetInt ("Resource") == 1)
		{
			StartCoroutine(Resource());
		}

		if(PlayerPrefs.GetInt ("BaitGet") == 1)
		{
			PlayerPrefs.SetInt("QuestPart", 7);
			StartCoroutine(JournalEntry());
		}
		if(PlayerPrefs.GetInt ("Bait") == 1)
		{
			StartCoroutine(Bait());
		}

		if(PlayerPrefs.GetInt ("CaughtGet") == 1)
		{
			PlayerPrefs.SetInt("QuestPart", 8);
			StartCoroutine(JournalEntry());
		}
		if(PlayerPrefs.GetInt ("Caught") == 1)
		{
			StartCoroutine(Caught());
		}

		if(PlayerPrefs.GetInt ("CapturedGet") == 1)
		{
			PlayerPrefs.SetInt("QuestPart", 9);
			StartCoroutine(JournalEntry());
			Destroy(Tut2Walls);
		}
		if(PlayerPrefs.GetInt ("Captured") == 1)
		{
			StartCoroutine(Captured());
		}

		if(PlayerPrefs.GetInt ("TrackGet") == 1)
		{
			StartCoroutine(TrackerEntry());
		}
		if(PlayerPrefs.GetInt ("Track") == 1)
		{
			StartCoroutine(Track());
		}

		if(PlayerPrefs.GetInt ("QuestGet") == 1)
		{
			PlayerPrefs.SetInt("QuestPart", 10);
			StartCoroutine(JournalEntry());
		}
		if(PlayerPrefs.GetInt ("Quest") == 1)
		{
			StartCoroutine(Quest());
		}

		if(PlayerPrefs.GetInt ("TrapTownGet") == 1)
		{
			PlayerPrefs.SetInt("QuestPart", 12);
			StartCoroutine(JournalEntry());
		}
		if(PlayerPrefs.GetInt ("TrapTown") == 1)
		{
			StartCoroutine(TrapTown());
		}

		if(PlayerPrefs.GetInt ("CaughtTownGet") == 1)
		{
			PlayerPrefs.SetInt("QuestPart", 13);
			StartCoroutine(JournalEntry());
		}
		if(PlayerPrefs.GetInt ("CaughtTown") == 1)
		{
			StartCoroutine(CaughtTown());
		}

		if(PlayerPrefs.GetInt ("CapturedTownGet") == 1)
		{
			PlayerPrefs.SetInt("QuestPart", 14);
			StartCoroutine(JournalEntry());
		}
		if(PlayerPrefs.GetInt ("CapturedTown") == 1)
		{
			StartCoroutine(CapturedTown());
		}
	}

	IEnumerator Wakeup()
	{
		wakingup = true;
		PlayerPrefs.SetInt ("TrapWait", 1);
		Player.transform.position = new Vector3(705.4106f, 11.39183f, 584.7635f);
		Player.transform.rotation = Quaternion.Euler(270,0,0);
		topBlack = 0f;
		botBlack = Screen.height/2f;
		disableMove();
		yield return new WaitForSeconds(2);
		Player.animation.Play("WakeUp");
		yield return new WaitForSeconds(3);
		Player.transform.position = new Vector3(705.9161f, 11.04025f, 584.7635f);
		Player.transform.rotation = Quaternion.Euler(0,90,0);
		enableMove();
		if(PlayerPrefs.GetInt("a") == 1)
		{
			PlayerPrefs.SetInt("QuestPart", 2);
			StartCoroutine(JournalEntry());
		}

		PlayerPrefs.SetInt ("a", PlayerPrefs.GetInt("a") +1);
		PlayerPrefs.SetInt ("GameStart", 1);
		wakingup = false;
	}

	IEnumerator Wakeup2()
	{		
		wakingup = true;
		PlayerPrefs.SetInt ("TrapWait", 1);
		Player.transform.position = new Vector3(-65.65939f, 0.4257758f, -97.16566f);
		Player.transform.rotation = Quaternion.Euler(-90,-47,0);
		topBlack = 0f;
		botBlack = Screen.height/2f;
		disableMove();
		yield return new WaitForSeconds(2);
		Player.animation.Play("WakeUp2");
		yield return new WaitForSeconds(3);
		Player.transform.position = new Vector3(-65.65939f, 1.075591f, -97.16566f);
		Player.transform.rotation = Quaternion.Euler(0,52,0);
		enableMove();
		wakingup = false;
	}

	IEnumerator JournalEntry()
	{
		JournalEntryPing = 1;
		yield return new WaitForSeconds(3);
		JournalEntryPing = 0;
	}

	IEnumerator TrackerEntry()
	{
		TrackerEntryPing = 1;
		yield return new WaitForSeconds(3);
		TrackerEntryPing = 0;
	}

	IEnumerator Resource()
	{
		PlayerPrefs.SetInt ("Resource", 2);
		PlayerPrefs.SetInt ("ResourceGet", 1);
		yield return new WaitForSeconds(1);
		PlayerPrefs.SetInt ("ResourceGet", 2);
	}

	IEnumerator Bait()
	{
		QuestPage = 2;
		PlayerPrefs.SetInt ("Bait", 2);
		PlayerPrefs.SetInt ("BaitGet", 1);
		yield return new WaitForSeconds(1);
		PlayerPrefs.SetInt ("BaitGet", 2);
	}

	IEnumerator Caught()
	{
		PlayerPrefs.SetInt ("Caught", 2);
		PlayerPrefs.SetInt ("CaughtGet", 1);
		yield return new WaitForSeconds(1);
		PlayerPrefs.SetInt ("CaughtGet", 2);
	}

	IEnumerator Captured()
	{
		PlayerPrefs.SetInt ("Captured", 2);
		PlayerPrefs.SetInt ("CapturedGet", 1);
		yield return new WaitForSeconds(1);
		PlayerPrefs.SetInt ("CapturedGet", 2);
	}

	IEnumerator Track()
	{
		PlayerPrefs.SetInt ("Track", 2);
		PlayerPrefs.SetInt ("TrackGet", 1);
		yield return new WaitForSeconds(1);
		PlayerPrefs.SetInt ("TrackGet", 2);
	}

	IEnumerator Quest()
	{
		PlayerPrefs.SetInt ("Quest", 2);
		PlayerPrefs.SetInt ("QuestGet", 1);
		yield return new WaitForSeconds(1);
		PlayerPrefs.SetInt ("QuestGet", 2);
	}

	IEnumerator TrapTown()
	{
		PlayerPrefs.SetInt ("TrapTown", 2);
		PlayerPrefs.SetInt ("TrapTownGet", 1);
		yield return new WaitForSeconds(1);
		PlayerPrefs.SetInt ("TrapTownGet", 2);
	}

	IEnumerator CaughtTown()
	{
		PlayerPrefs.SetInt ("CaughtTown", 2);
		PlayerPrefs.SetInt ("CaughtTownGet", 1);
		yield return new WaitForSeconds(1);
		PlayerPrefs.SetInt ("CaughTowntGet", 2);
	}

	IEnumerator CapturedTown()
	{
		PlayerPrefs.SetInt ("CapturedTown", 2);
		PlayerPrefs.SetInt ("CapturedTownGet", 1);
		yield return new WaitForSeconds(1);
		PlayerPrefs.SetInt ("CapturedTownGet", 2);
	}

	void OnTriggerStay(Collider other)
	{
		if (other.name == "mouseCollider") 
		{
			if(Input.GetKey(KeyCode.E))
			{
				if(PlayerPrefs.GetInt("b") < 2)
				{
					Trap1 = 1;
					PlayerPrefs.SetInt("QuestPart", 5);
					StartCoroutine(JournalEntry());
					PlayerPrefs.SetInt ("b", PlayerPrefs.GetInt("b") +1);
				}
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.name == "Tut1")
		{
			TutorialInt = 1;
		}
		if(other.name == "Tut2")
		{
			TutorialInt = 2;
		}
		if(other.name == "Tut3")
		{
			TutorialInt = 3;
		}
		if(other.name == "Tut4")
		{
			TutorialInt = 4;
		}
		if(other.name == "mouseCollider")
		{
			TutorialInt = 5;
		}
		if(other.name == "BedCollider")
		{
			TutorialInt = 6;
		}
		if(other.name == "TutColl")
		{
			TutorialInt = 7;
		}
		if(other.name == "TutColl2")
		{
			TutorialInt = 8;
		}
		if(other.tag == "Resource")
		{
			TutorialInt = 9;
		}
		if(other.name == "SleepingBag")
		{
			TutorialInt = 10;
		}
		if(other.name == "InvisWall2")
		{
			TutorialInt = 11;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.name == "InvisWall2" || other.name == "SleepingBag" || other.name == "Tut1" || other.name == "Tut2" || other.name == "Tut3" || other.name == "Tut4" || other.name == "Tut5" || other.name == "BedCollider" || other.name == "mouseCollider" || other.name == "TutColl" || other.name == "TutColl2" || other.name == "Resource")
		{
			TutorialInt = 0;
			Tutorial = 0;
		}
	}

	void tutorialWindowMethod(int windowID)
	{	
		GUILayout.BeginArea (new Rect(35, 50, 600, 800));
		GUI.skin.box.normal.textColor=Color.black;

		if(Tutorial == 1)
		{
			GUI.skin.box.fontSize = 70;
			GUI.Box (new Rect (95, 10, 400, 160), "To Do List");
			GUI.Box (new Rect (80, 25, 400, 100), "_________");
			GUI.skin.box.fontSize = 28;
			GUI.Box (new Rect (30, 160, 450, 1000), "- Gather resources, discover tracks, and make traps to catch animals");
			GUI.Box (new Rect (30, 270, 450, 1000), "- Use these animals as bait for other traps, or eat them to replinish your hunger");
			GUI.Box (new Rect (30, 380, 450, 1000), "- You can see your hunger bar on the top right of your screen. You will need to eat regularly to prevent starvation");
			GUI.Box (new Rect (30, 520, 450, 1000), "- Press J to open your journal and see what your next course of action is");
			GUI.Box (new Rect (30, 630, 450, 1000), "- You can press Esc to close any windows you have open");
		}
		else if(Tutorial == 2)
		{
			GUI.skin.box.fontSize = 70;
			GUI.Box (new Rect (95, 10, 400, 160), "To Do List");
			GUI.Box (new Rect (80, 25, 400, 100), "_________");
			GUI.skin.box.fontSize = 28;
			GUI.Box (new Rect (30, 180, 450, 1000), "- There are resources like this pile of logs throughout the world");
			GUI.Box (new Rect (30, 300, 450, 1000), "- To collect the resources, get close and press E to bring up the Resource window");
			GUI.Box (new Rect (30, 420, 450, 1000), "- To move the resource to your inventory, simply click on the resources in the window");
		}
		else if(Tutorial == 3)
		{
			GUI.skin.box.fontSize = 70;
			GUI.Box (new Rect (95, 10, 400, 160), "To Do List");
			GUI.Box (new Rect (80, 25, 400, 100), "_________");
			GUI.skin.box.fontSize = 28;
			GUI.Box (new Rect (30, 180, 450, 1000), "- There are tracks like the one next to this sign all over the world");
			GUI.Box (new Rect (30, 300, 450, 1000), "- These tracks can be used to obtain information about potential game");
			GUI.Box (new Rect (30, 420, 450, 1000), "- Press E when you are close, and your Tracker Log will update");
			GUI.Box (new Rect (30, 540, 450, 1000), "- Press T to open your Tracker Log to find what made these tracks and what its preferred bait is");
		}

		else if(Tutorial == 4)
		{
			GUI.skin.box.fontSize = 70;
			GUI.Box (new Rect (95, 10, 400, 160), "To Do List");
			GUI.Box (new Rect (80, 25, 400, 100), "_________");
			GUI.skin.box.fontSize = 28;
			GUI.Box (new Rect (30, 140, 450, 1000), "- To craft a trap, open your inventory by pressing I");
			GUI.Box (new Rect (30, 215, 450, 1000), "- Next open the crafting window by pressing C");
			GUI.Box (new Rect (30, 290, 450, 1000), "- Click on the resources in your inventory to put them into the crafting window");
			GUI.Box (new Rect (30, 395, 450, 1000), "- If the resources are compatible for a trap, the trap will appear in the crafting window; click to put it into your inventory");
			GUI.Box (new Rect (30, 565, 450, 1000), "- To place the trap, simply click on the trap from your inventory window and it will be put into your hands. Press F to place it in the desired position");
		}

		GUILayout.EndArea();
	}

	void journalWindowMethod(int windowID)
	{
		GUILayout.BeginArea (new Rect(35, 50, 1000, 600));
		GUI.skin.box.normal.textColor=Color.black;

		if(QuestPage == 1)
		{
			// Page 1																																							            // ! No text past this point
			if(PlayerPrefs.GetInt ("QuestPart") > 0)
				GUI.Box (new Rect (80, 10, 400, 160), "I had that dream again... blood... screaming... One day these dreams will become reality... one day...");
			if(PlayerPrefs.GetInt ("QuestPart") > 1)
				GUI.Box (new Rect (80, 150, 400, 160), "But first, I need to fill my belly... Nothing to eat here... I'm going to have to catch something tasty to get me going.");
			if(PlayerPrefs.GetInt ("QuestPart") > 2)
				GUI.Box (new Rect (80, 320, 400, 160), "I'll need something to catch my unwitting prey... I should go outside and see what I can find to improvise a trap of some sort.");
			// Page 2
			if(PlayerPrefs.GetInt ("TutorialOrder") == 1) 
			{
				if(PlayerPrefs.GetInt ("QuestPart") > 3)
					GUI.Box (new Rect (495, 10, 400, 160), "I found the tracks of a mouse... I suppose beggers can't be choosers... Now to catch one...");
			}
			else if(PlayerPrefs.GetInt ("TutorialOrder") == 2) 
			{
				if(PlayerPrefs.GetInt ("QuestPart") > 3)
					GUI.Box (new Rect (495, 10, 400, 160), "I found the parts I need to make a trap... Now to find something to catch");
			}
			else if(PlayerPrefs.GetInt ("TutorialOrder") == 3) 
			{
				if(PlayerPrefs.GetInt ("QuestPart") > 3)
					GUI.Box (new Rect (495, 10, 400, 160), "I've worked out how to craft a trap... Now to find the resources I need and something to catch");
			}

			if(PlayerPrefs.GetInt ("TutorialOrder2") == 1) 
			{
				if(PlayerPrefs.GetInt ("QuestPart") > 4)
					GUI.Box (new Rect (495, 150, 400, 160), "I found the parts I need to make a trap to catch one of the little buggers... Let's put those sixth-grade shop classes to use");
			}
			else if(PlayerPrefs.GetInt ("TutorialOrder2") == 2) 
			{
				if(PlayerPrefs.GetInt ("QuestPart") > 4)
					GUI.Box (new Rect (495, 150, 400, 160), "I've worked out how to craft a trap... Now to find the resources I need and then put those sixth-grade shop classes to use");
			}
			else if(PlayerPrefs.GetInt ("TutorialOrder2") == 3) 
			{
				if(PlayerPrefs.GetInt ("QuestPart") > 4)
					GUI.Box (new Rect (495, 150, 400, 160), "I found the tracks of a mouse... I suppose beggers can't be choosers... Now to craft the trap to catch one");
			}
			else if(PlayerPrefs.GetInt ("TutorialOrder2") == 4) 
			{
				if(PlayerPrefs.GetInt ("QuestPart") > 4)
					GUI.Box (new Rect (495, 150, 400, 160), "I've worked out how to craft a trap... Now to find something to catch and then put those sixth-grade shop classes to use");
			}
			else if(PlayerPrefs.GetInt ("TutorialOrder2") == 5) 
			{
				if(PlayerPrefs.GetInt ("QuestPart") > 4)
					GUI.Box (new Rect (495, 150, 400, 160), "I found the tracks of a mouse... I suppose beggers can't be choosers... Now to find those parts");
			}
			else if(PlayerPrefs.GetInt ("TutorialOrder2") == 6) 
			{
				if(PlayerPrefs.GetInt ("QuestPart") > 4)
					GUI.Box (new Rect (495, 150, 400, 160), "I found the parts I need for the trap... Now to find something tasty to catch with it");
			}
			if(PlayerPrefs.GetInt ("QuestPart") > 5)
			{
				GUI.skin.box.fontSize = 26;
				GUI.Box (new Rect (495, 320, 400, 200), "Now that I've set the trap, I can add bait to it by pressing E on it and adding any bait I have from my inventory... That nut I found should increase my chances of catching that mouse");
				GUI.skin.box.fontSize = 28;
			}
		}
		else if(QuestPage == 2)
		{
			// Page 3																																							            // ! No text past this point
			if(PlayerPrefs.GetInt ("QuestPart") > 6)
				GUI.Box (new Rect (80, 10, 400, 160), "I need to wait for a while for my prey to come for that bait... I'll have a quick nap in my cabin...");
			if(PlayerPrefs.GetInt ("QuestPart") > 7)
				GUI.Box (new Rect (80, 180, 400, 160), "Success! I caught the little blighter... Now, do I want to eat this now, or save it for later to catch something even juicier?");
			if(PlayerPrefs.GetInt ("QuestPart") > 8)
				GUI.Box (new Rect (80, 350, 400, 160), "Now that I've worked out how to catch small game, it's time to venture out into the world and make better traps for bigger prey");
			
			// Page 4
			if(PlayerPrefs.GetInt ("QuestPart") > 9)
				GUI.Box (new Rect (495, 10, 400, 160), "My first trip into town... I picked a good time to come... Lurking in the shadows... What can I find to lure into my traps?..");
			if(PlayerPrefs.GetInt ("QuestPart") > 10)
				GUI.Box (new Rect (495, 180, 400, 160), "There must be resources a plenty around here... I should check the bins for parts, I'm sure I can find something useful");
			if(PlayerPrefs.GetInt ("QuestPart") > 11)
				GUI.Box (new Rect (495, 350, 400, 160), "I wonder what... Or who... I'll catch this time... I'll need somewhere to wait... How about that derelict building near the entrance");
		}
		else if(QuestPage == 3)
		{
			// Page 5	
			if(PlayerPrefs.GetInt ("QuestPart") > 12)
				GUI.Box (new Rect (80, 10, 400, 160), "My first human... I've dreamed about this for as long as I can remember... How does human flesh taste? Do I dare find out?");
			if(PlayerPrefs.GetInt ("QuestPart") > 13)
				GUI.Box (new Rect (80, 180, 400, 160), "I've crossed that line... There's no going back now... I need more... I need better... Who to catch next? A priest? A student? The mayor?!..");
			if(PlayerPrefs.GetInt ("QuestPart") > 14)
				GUI.Box (new Rect (80, 350, 400, 160), "");
			
			// Page 6
			GUI.Box (new Rect (495, 10, 400, 160), "");
			GUI.Box (new Rect (495, 180, 400, 160), "");
			GUI.Box (new Rect (495, 350, 400, 160), "");
		}

		if(JournalOpen == true && QuestPage > 1)
		{
			if(GUI.Button(new Rect(30, 230, 40, 40), ArrowLeft))
			{
				QuestPage--;
			}
		}
		if(JournalOpen == true && QuestPage < 3)
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
		GUI.skin.box.normal.textColor=Color.black;

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
				GUI.Box (new Rect (80, 355, 140, 35), "Raccoon");
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
			GUI.Box (new Rect (80, 0, 140, 35), "Name");
			GUI.Box (new Rect (220, 0, 120, 35), "Location");
			GUI.Box (new Rect (360, 0, 110, 35), "Bait");
			GUI.Box (new Rect (80, 2, 400, 40), "_______________________________");
			
			if(PlayerPrefs.GetInt ("Animal19") == 0)
			{
				GUI.Box (new Rect (80, 70, 400, 35), " ?????      ?????        ?????");
				GUI.Box (new Rect (772, 105, 400, 35), "?????");
			}
			else
			{
				GUI.Box (new Rect (80, 70, 140, 35), "Druggy");
				GUI.Box (new Rect (220, 70, 120, 35), "Derelict");
				GUI.Box (new Rect (220, 105, 120, 35), "Building");
				GUI.Box (new Rect (360, 70, 110, 35), "Meth");
			}
			
			if(PlayerPrefs.GetInt ("Animal20") == 0)
			{
				GUI.Box (new Rect (80, 160, 400, 35), " ?????      ?????        ?????");
				GUI.Box (new Rect (72, 195, 400, 35), "????? ");
			}
			else
			{
				GUI.Box (new Rect (80, 160, 140, 35), "Whore");
				GUI.Box (new Rect (220, 160, 120, 35), "Low-Class");
				GUI.Box (new Rect (220, 195, 120, 35), "Housing");
				GUI.Box (new Rect (360, 160, 110, 35), "Money");
			}
			
			if(PlayerPrefs.GetInt ("Animal21") == 0)
				GUI.Box (new Rect (80, 250, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (80, 250, 140, 35), "Drunk");
				GUI.Box (new Rect (220, 250, 120, 35), "Pub");
				GUI.Box (new Rect (360, 250, 110, 35), "Beer");
			}
			
			if(PlayerPrefs.GetInt ("Animal22") == 0)
			{
				GUI.Box (new Rect (80, 340, 400, 35), " ?????      ?????        ?????");
				GUI.Box (new Rect (5, 375, 400, 35), " ?????      ?????");
			}
			else
			{
				GUI.Box (new Rect (80, 340, 140, 35), "Homeless");
				GUI.Box (new Rect (80, 375, 140, 35), "Person");
				GUI.Box (new Rect (220, 340, 120, 35), "Shopping");
				GUI.Box (new Rect (220, 375, 120, 35), "Mall");
				GUI.Box (new Rect (360, 340, 110, 35), "Money");
			}
			
			if(PlayerPrefs.GetInt ("Animal23") == 0)
			{
				GUI.Box (new Rect (80, 430, 400, 35), " ?????      ?????        ?????");
				GUI.Box (new Rect (72, 465, 400, 35), "?????");
			}
			else
			{
				GUI.Box (new Rect (80, 430, 140, 35), "Binman");
				GUI.Box (new Rect (220, 430, 120, 35), "Apart-");
				GUI.Box (new Rect (220, 465, 120, 35), "ments");
				GUI.Box (new Rect (360, 430, 110, 35), "Money");
			}
			//---------------------------------------------------------------------
			
			//Page 4
			GUI.Box (new Rect (495, 0, 140, 35), "Name");
			GUI.Box (new Rect (635, 0, 120, 35), "Location");
			GUI.Box (new Rect (775, 0, 110, 35), "Bait");
			GUI.Box (new Rect (495, 2, 400, 40), "_______________________________");
			
			if(PlayerPrefs.GetInt ("Animal24") == 0)
				GUI.Box (new Rect (495, 70, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (495, 70, 150, 35), "Pharmacist");
				GUI.Box (new Rect (635, 70, 120, 35), "Shops");
				GUI.Box (new Rect (770, 70, 110, 35), "Mouse");
			}
			
			if(PlayerPrefs.GetInt ("Animal25") == 0)
			{
				GUI.Box (new Rect (495, 160, 400, 35), " ?????      ?????        ?????");
				GUI.Box (new Rect (560, 195, 400, 35), "?????        ?????");
			}
			else
			{
				GUI.Box (new Rect (495, 160, 140, 35), "Goth");
				GUI.Box (new Rect (635, 160, 120, 35), "Church");
				GUI.Box (new Rect (615, 195, 150, 35), "Graveyard");
				GUI.Box (new Rect (755, 160, 150, 35), "Lovecraft");
				GUI.Box (new Rect (770, 195, 110, 35), "Book");
			}
			
			if(PlayerPrefs.GetInt ("Animal26") == 0)
				GUI.Box (new Rect (495, 250, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (495, 250, 140, 35), "Priest");
				GUI.Box (new Rect (635, 250, 120, 35), "Church");
				GUI.Box (new Rect (770, 250, 110, 35), "Mouse");
			}
			
			if(PlayerPrefs.GetInt ("Animal27") == 0)
			{
				GUI.Box (new Rect (495, 340, 400, 35), " ?????      ?????        ?????");
				GUI.Box (new Rect (487, 375, 400, 35), "?????");
			}
			else
			{
				GUI.Box (new Rect (495, 340, 140, 35), "Banker");
				GUI.Box (new Rect (620, 340, 150, 35), "High-class");
				GUI.Box (new Rect (635, 375, 120, 35), "Housing");
				GUI.Box (new Rect (770, 340, 110, 35), "Money");
			}
			
			if(PlayerPrefs.GetInt ("Animal28") == 0)
				GUI.Box (new Rect (495, 430, 400, 35), " ?????      ?????        ?????");
			else
			{
				GUI.Box (new Rect (495, 430, 140, 35), "Mayor");
				GUI.Box (new Rect (635, 430, 120, 35), "Mansion");
				GUI.Box (new Rect (770, 430, 110, 35), "Sextape");
			}
		}			

		if(TrackerOpen == true && TrackerPage > 1)
		{
			if(GUI.Button(new Rect(30, 230, 40, 40), ArrowLeft))
			{
				TrackerPage--;
			}
		}
		if(TrackerOpen == true && TrackerPage < 2)
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
		if (TutorialInt == 7) 
		{
			GUI.DrawTexture(new Rect(Screen.width/2-90,Screen.height/2-30,180,60), blackTexture);
			GUI.contentColor = Color.red;
			GUI.Label(new Rect(Screen.width/2-65, Screen.height/2-10, 200, 200), "Check your To Do List");
			GUI.contentColor = Color.white;
		}
		
		if (TutorialInt == 8) 
		{
			GUI.DrawTexture(new Rect(Screen.width/2-90,Screen.height/2-30,180,60), blackTexture);
			GUI.contentColor = Color.red;
			GUI.Label(new Rect(Screen.width/2-65, Screen.height/2-10, 200, 200), "Learn to craft a trap");
			GUI.contentColor = Color.white;
		}

		if(JournalEntryPing == 1)
		{
			GUI.DrawTexture(new Rect(Screen.width-350,220,250,100), JournalTexture);
			GUI.contentColor = Color.black;
			GUI.Label (new Rect(Screen.width-250, 260, 500, 500), "New Journal Entry!");
			GUI.contentColor = Color.white;
		}

		if(TrackerEntryPing == 1)
		{
			GUI.DrawTexture(new Rect(Screen.width-350,330,250,100), TrackerTexture);
			GUI.contentColor = Color.red;
			GUI.Label (new Rect(Screen.width-250, 370, 500, 500), "New Tracker Entry!");
			GUI.contentColor = Color.white;
		}

		GUI.DrawTexture (new Rect(0, topBlack, Screen.width, Screen.height/2), black);
		GUI.DrawTexture (new Rect(0, botBlack, Screen.width, Screen.height), black);

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
		else if(Tutorial > 0)
		{
			GUI.skin=paperGUI;
			tutorialWindowRect = GUI.Window (0, tutorialWindowRect, tutorialWindowMethod, "");

			/*GUI.skin=paperHeader;
			tutorialHeaderWindowRect = GUI.Window (0, tutorialHeaderWindowRect, tutorialHeaderWindowMethod, "");*/
		}

		if (PlayerPrefs.GetInt ("Hunger") == 240) 
		{
			StartCoroutine (HungerFlashy ());
			PlayerPrefs.SetInt ("HungerText", 1);
		}
		if (PlayerPrefs.GetInt ("Hunger") == 238)
			StartCoroutine (HungerFlashy ());
		if (PlayerPrefs.GetInt ("Hunger") == 236)
			StartCoroutine (HungerFlashy ());
		if (PlayerPrefs.GetInt ("Hunger") == 234)
			PlayerPrefs.SetInt("HungerText", 0);

		if (PlayerPrefs.GetInt ("Hunger") == 120) 
		{
			StartCoroutine (HungerFlashy ());
			PlayerPrefs.SetInt ("HungerText", 2);
		}
		if (PlayerPrefs.GetInt ("Hunger") == 118)
			StartCoroutine (HungerFlashy ());
		if (PlayerPrefs.GetInt ("Hunger") == 116)
			StartCoroutine (HungerFlashy ());
		if (PlayerPrefs.GetInt ("Hunger") == 114)
			PlayerPrefs.SetInt("HungerText", 0);

		if (PlayerPrefs.GetInt ("Hunger") == 30) 
		{
			StartCoroutine (HungerFlashy ());
			PlayerPrefs.SetInt ("HungerText", 4);
		}
		if (PlayerPrefs.GetInt ("Hunger") == 28)
			StartCoroutine (HungerFlashy ());
		if (PlayerPrefs.GetInt ("Hunger") == 26)
			StartCoroutine (HungerFlashy ());
		if (PlayerPrefs.GetInt ("Hunger") == 24)
			PlayerPrefs.SetInt("HungerText", 0);


		if(PlayerPrefs.GetInt ("Hunger") > 240) //240
			GUI.Label (new Rect(Screen.width/2+700, Screen.height/2-400, 500, 500), HungerFull);
		else if(PlayerPrefs.GetInt ("Hunger") > 120) //120
		{
			GUI.Label (new Rect(Screen.width/2+700, Screen.height/2-400, 500, 500), Hunger2);
		}
		else if(PlayerPrefs.GetInt ("Hunger") > 30)//30
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