using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JP_FG_CraftingGUI : MonoBehaviour 
{

	private Rect craftingWindowRect = new Rect(600,100,400,400);
	private bool CraftingUp = false;

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
		{6, itemObject.nullItem},
		{7, itemObject.nullItem}
	};

	// Use this for initialization
	void Start () 
	{
	
	}

	void OnGUI()
	{
		if(CraftingUp)
		{
			craftingWindowRect = GUI.Window (2, craftingWindowRect, CraftingWindowMethod, "Crafting");
		}
		
		
	}

	void CraftingWindowMethod(int windowID)
	{
		GUILayout.BeginArea (new Rect(5, 50, 390, 400));
		
		GUILayout.BeginHorizontal();
		if(GUILayout.Button (craftingDictionary [0].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{

		}
		GUILayout.Button (craftingDictionary[1].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (craftingDictionary[2].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.EndHorizontal();
		
		GUILayout.BeginHorizontal();
		GUILayout.Button (craftingDictionary[3].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (craftingDictionary[4].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (craftingDictionary[5].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.EndHorizontal();
		
		GUILayout.BeginHorizontal();
		if(GUILayout.Button ("Create", GUILayout.Width (50), GUILayout.Height (50)))
		{
			craftingDictionary[6] = JP_FG_Recipes.GetRecipe ();
		}
		if(GUILayout.Button (craftingDictionary[6].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{

			for(int i = 0; i < 9; i++)
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
			GUILayout.EndHorizontal();
		
		GUILayout.EndArea ();

		
	}

	// Update is called once per frame
	void Update () 
	{

		if(Input.GetKeyDown (KeyCode.C))
		{
			CraftingUp = true;
		}

		if(Input.GetKeyUp (KeyCode.Escape))
		{
			if(CraftingUp)
			{
				CraftingUp = false;
			}
		}
	
	}
}
