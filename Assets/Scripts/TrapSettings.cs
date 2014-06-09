using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TrapSettings : MonoBehaviour 
{
	bool isEmpty = true;
	bool canMove = true;
	Item_Class.ItemClass itemObject = new Item_Class.ItemClass();
	public static Item_Class baitItem = new Item_Class();
	public GUISkin trapSkin;
	GameObject Player;

	// Trap Variables
	private Rect baitWindowRect = new Rect(600,100,150,150);
	private bool BaitUp = false;
	private int BaitID = 0;
	MF_TrapScript trapScript;

	public Dictionary<int, Item_Class.ItemClass> BaitNameDictionary = new Dictionary<int, Item_Class.ItemClass>()
	{
		{0, baitItem.nullItem}
	};
	
	public void DisableMovement()
	{
		Player.gameObject.GetComponent<MouseLook>().enabled = false;
		Player.gameObject.GetComponent<FPSInputController>().enabled = false;
		Player.gameObject.GetComponent<CharacterMotor>().enabled = false;
		Player.gameObject.transform.Find ("Main Camera").GetComponent<MouseLook>().enabled = false;
	}

	public void EnableMovement()
	{
		Player.gameObject.GetComponent<MouseLook>().enabled = true;
		Player.gameObject.GetComponent<FPSInputController>().enabled = true;
		Player.gameObject.GetComponent<CharacterMotor>().enabled = true;
		Player.gameObject.transform.Find ("Main Camera").GetComponent<MouseLook>().enabled = true;
	}

	public Dictionary<int, Item_Class.ItemClass> GetBaitDictionary()
	{
		return BaitNameDictionary;
	}

	public bool GetEmpty()
	{
		return isEmpty;
	}

	public void SetEmpty(bool newEmpty)
	{
		isEmpty = newEmpty;
	}

	public string GetName()
	{
		return BaitNameDictionary [0].name;
	}

	public void SetBaitDictionary(Item_Class.ItemClass newObject)
	{
		BaitNameDictionary [0] = newObject;
	}

	public bool GetBaitWindow()
	{
		return BaitUp;
	}
	
	public void SetBaitWindow(bool name)
	{
		BaitUp = name;
	}

	public int GetBait()
	{
		return BaitID;
	}

	public bool GetCanMove()
	{
		return canMove;
	}

	public void SetTrapType(Item_Class.ItemClass newObject)
	{
		itemObject = newObject;
	}

	public Item_Class.ItemClass GetTrap()
	{
		return itemObject;
	}

	void Start()
	{
		Player = GameObject.FindGameObjectWithTag("Player");
		itemObject = Player.GetComponent<JP_TrapSelection>().GetTrap ();
		gameObject.tag = "Trap";
		trapScript = gameObject.GetComponent<MF_TrapScript>();
	}

	void OnGUI()
	{
		if (BaitUp)
		{
			GUI.skin = trapSkin;
			baitWindowRect = GUI.Window (6, baitWindowRect, BaitWindowMethod, "Bait"); 
		}

	}

	void BaitWindowMethod(int windowID)
	{	
		GUI.skin = trapSkin;
		GUILayout.BeginArea (new Rect(75, 50, 150, 150));
		
		GUILayout.BeginHorizontal();
		if(GUILayout.Button (BaitNameDictionary[0].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(BaitNameDictionary[0].name != "null")
			{
				for(int j = 0; j < 36; j++)
				{
					if(JP_InventoryGUI.inventoryNameDictionary[j].name == "null")
					{
						JP_InventoryGUI.inventoryNameDictionary[j] = BaitNameDictionary[0];
						BaitNameDictionary[0] = baitItem.nullItem;
						BaitID = 0;
						break;
					}
				}
			}
		}
		GUILayout.EndHorizontal ();

		GUILayout.EndArea ();
	}

	void Update () 
	{
		
		if (BaitID < 1 && BaitNameDictionary[0].name != "null")
		{
			BaitID = BaitNameDictionary[0].baitID;
			trapScript.Deploy(itemObject.TrapID, BaitID);
		}

		if(BaitUp)
		{
			DisableMovement();
		}

		if(Input.GetKeyUp (KeyCode.Escape))
		{
			if(BaitUp)
			{
				PlayerPrefs.SetInt ("Bait", 1);
				EnableMovement();
				BaitUp = false;
			}
		}

		if(Input.GetKeyUp (KeyCode.K))
		{
			Debug.Log (BaitID);
		}
		
	}


}
