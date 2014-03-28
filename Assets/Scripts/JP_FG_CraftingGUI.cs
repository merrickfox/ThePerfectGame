using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JP_FG_CraftingGUI : MonoBehaviour 
{
	
	private Rect craftingWindowRect = new Rect(600,100,400,300);
	public static bool CraftingUp = false;
	public GUISkin craftingSkin;
	public Texture2D hammerIcon;
	public Texture2D clearIcon;
	
	//Item_Class itemObject = new Item_Class();
	public static Item_Class itemObject = new Item_Class();
	
	
	static public Dictionary<int, Item_Class.ItemClass> craftingDictionary = new Dictionary<int, Item_Class.ItemClass>()
	{
		{0, itemObject.nullItem},
		{1, itemObject.nullItem},
		{2, itemObject.nullItem},
		{3, itemObject.nullItem},
		{4, itemObject.nullItem},
		{5, itemObject.nullItem},
		{6, itemObject.nullItem}
	};
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	public bool GetWindowOpen()
	{
		return CraftingUp;
	}
	
	public void SetWindowOpen(bool newBool)
	{
		CraftingUp = newBool;
	}
	
	void OnGUI()
	{
		if(CraftingUp)
		{
			GUI.skin = craftingSkin;
			craftingWindowRect = GUI.Window (2, craftingWindowRect, CraftingWindowMethod, "Crafting");
		}
		
		
	}
	
	void CraftingWindowMethod(int windowID)
	{
		GUILayout.BeginArea (new Rect(5, 50, 390, 300));
		
		GUILayout.BeginHorizontal();
		GUILayout.Space (50f);
		if(GUILayout.Button (craftingDictionary [0].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(craftingDictionary[0].name != "null")
			{
				for(int i = 0; i < 36; i++)
				{
					if(JP_InventoryGUI.inventoryNameDictionary[i].name == "null")
					{
						JP_InventoryGUI.inventoryNameDictionary[i] = craftingDictionary[0];
						craftingDictionary[0] = itemObject.nullItem;
						break;
					}
				}
			}
		}
		GUILayout.Space (50f);
		if(GUILayout.Button (craftingDictionary[1].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(craftingDictionary[1].name != "null")
			{
				for(int i = 0; i < 36; i++)
				{
					if(JP_InventoryGUI.inventoryNameDictionary[i].name == "null")
					{
						JP_InventoryGUI.inventoryNameDictionary[i] = craftingDictionary[1];
						craftingDictionary[1] = itemObject.nullItem;
						break;
					}
				}
			}
		}
		GUILayout.Space (50f);
		if(GUILayout.Button (craftingDictionary[2].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(craftingDictionary[2].name != "null")
			{
				for(int i = 0; i < 36; i++)
				{
					if(JP_InventoryGUI.inventoryNameDictionary[i].name == "null")
					{
						JP_InventoryGUI.inventoryNameDictionary[i] = craftingDictionary[2];
						craftingDictionary[2] = itemObject.nullItem;
						break;
					}
				}
			}
		}
		GUILayout.Space (50f);
		GUILayout.EndHorizontal();
		
		GUILayout.BeginHorizontal();
		GUILayout.Space (50f);
		if(GUILayout.Button (craftingDictionary[3].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(craftingDictionary[3].name != "null")
			{
				for(int i = 0; i < 36; i++)
				{
					if(JP_InventoryGUI.inventoryNameDictionary[i].name == "null")
					{
						JP_InventoryGUI.inventoryNameDictionary[i] = craftingDictionary[3];
						craftingDictionary[3] = itemObject.nullItem;
						break;
					}
				}
			}
		}
		GUILayout.Space (50f);
		if(GUILayout.Button (craftingDictionary[4].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(craftingDictionary[4].name != "null")
			{
				for(int i = 0; i < 36; i++)
				{
					if(JP_InventoryGUI.inventoryNameDictionary[i].name == "null")
					{
						JP_InventoryGUI.inventoryNameDictionary[i] = craftingDictionary[4];
						craftingDictionary[4] = itemObject.nullItem;
						break;
					}
				}
			}
		}
		GUILayout.Space (50f);
		if(GUILayout.Button (craftingDictionary[5].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(craftingDictionary[5].name != "null")
			{
				for(int i = 0; i < 36; i++)
				{
					if(JP_InventoryGUI.inventoryNameDictionary[i].name == "null")
					{
						JP_InventoryGUI.inventoryNameDictionary[i] = craftingDictionary[5];
						craftingDictionary[5] = itemObject.nullItem;
						break;
					}
				}
			}
		}
		GUILayout.EndHorizontal();
		
		GUILayout.BeginVertical ();
		GUILayout.Space (25f);
		GUILayout.EndVertical ();
		
		GUILayout.BeginHorizontal();
		GUILayout.Space (75f);
		if(GUILayout.Button (hammerIcon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			craftingDictionary[6] = JP_FG_Recipes.GetRecipe ();

			for (int i = 0; i < 6; i++)
			{
				if(craftingDictionary[i].name != "null")
				{
					for (int j = 0; j < 36; j++)
					{
						if(JP_InventoryGUI.inventoryNameDictionary[j].name == "null")
						{
							craftingDictionary[i] = itemObject.nullItem;
							break;
						}
					}
				}
			}
		}
		GUILayout.Space (25f);
		if(GUILayout.Button (craftingDictionary[6].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			
			for(int i = 0; i < 36; i++)
			{
				if(JP_InventoryGUI.inventoryNameDictionary[i].name == "null")
				{
					for(int j = 0; j < 6; j++)
					{
						craftingDictionary[j] = itemObject.nullItem;
					}
					
					JP_InventoryGUI.inventoryNameDictionary[i] = craftingDictionary[6];
					craftingDictionary[6] = itemObject.nullItem;
					break;
				}
			}
		}
		GUILayout.Space (25f);
		if(GUILayout.Button (clearIcon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			for (int i = 0; i < 6; i++)
			{
				if(craftingDictionary[i].name != "null")
				{
					for (int j = 0; j < 36; j++)
					{
						if(JP_InventoryGUI.inventoryNameDictionary[j].name == "null")
						{
							JP_InventoryGUI.inventoryNameDictionary[j] = craftingDictionary[i];
							craftingDictionary[i] = itemObject.nullItem;
							break;
						}
					}
				}
			}
		}
		GUILayout.EndHorizontal();
		
		GUILayout.EndArea ();
		
		
	}

	void DisableMovement()
	{
		gameObject.GetComponent<MouseLook>().enabled = false;
		gameObject.GetComponent<FPSInputController>().enabled = false;
		gameObject.GetComponent<CharacterMotor>().enabled = false;
		transform.Find ("Main Camera").GetComponent<MouseLook>().enabled = false;
	}
	
	void EnableMovement()
	{
		gameObject.GetComponent<MouseLook>().enabled = true;
		gameObject.GetComponent<FPSInputController>().enabled = true;
		gameObject.GetComponent<CharacterMotor>().enabled = true;
		transform.Find ("Main Camera").GetComponent<MouseLook>().enabled = true;
	}

	// Update is called once per frame
	void Update () 
	{
		
		if(Input.GetKeyDown (KeyCode.C))
		{
			CraftingUp = true;
			DisableMovement ();
		}
		
		if(Input.GetKeyUp (KeyCode.Escape))
		{
			if(CraftingUp)
			{
				CraftingUp = false;
				EnableMovement();
			}
		}
		
	}


}
