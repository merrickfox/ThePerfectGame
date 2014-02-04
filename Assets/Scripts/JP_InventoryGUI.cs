using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JP_InventoryGUI : MonoBehaviour {

	private Rect inventoryWindowRect = new Rect(100,100,400,400);
	private bool InventoryUp = false;

	//Item_Class itemObject = new Item_Class();
	public static Item_Class itemObject = new Item_Class();

	static public Dictionary<int, Item_Class.ItemClass> inventoryNameDictionary = new Dictionary<int, Item_Class.ItemClass>()
	{
		{0, itemObject.nullItem},
		{1, itemObject.nullItem},
		{2, itemObject.nullItem},
		{3, itemObject.nullItem},
		{4, itemObject.nullItem},
		{5, itemObject.nullItem},
		{6, itemObject.nullItem},
		{7, itemObject.nullItem},
		{8, itemObject.nullItem},
		{9, itemObject.nullItem},
		{10, itemObject.nullItem},
		{11, itemObject.nullItem},
		{12, itemObject.nullItem},
		{13, itemObject.nullItem},
		{14, itemObject.nullItem},
		{15, itemObject.nullItem},
		{16, itemObject.nullItem},
		{17, itemObject.nullItem},
		{18, itemObject.nullItem},
		{19, itemObject.nullItem},
		{20, itemObject.nullItem},
		{21, itemObject.nullItem},
		{22, itemObject.nullItem},
		{23, itemObject.nullItem},
		{24, itemObject.nullItem},
		{25, itemObject.nullItem},
		{26, itemObject.nullItem},
		{27, itemObject.nullItem},
		{28, itemObject.nullItem},
		{29, itemObject.nullItem},
		{30, itemObject.nullItem},
		{31, itemObject.nullItem},
		{32, itemObject.nullItem},
		{33, itemObject.nullItem},
		{34, itemObject.nullItem},
		{35, itemObject.nullItem}
	};

	// Use this for initialization
	void Start () 
	{

	}

	void OnGUI()
	{
		if(InventoryUp)
		{
			inventoryWindowRect = GUI.Window (0, inventoryWindowRect, InventoryWindowMethod, "Inventory");
		}


	}

	void InventoryWindowMethod(int windowID)
	{
	
		GUILayout.BeginArea (new Rect(35, 50, 390, 400));

		GUILayout.BeginHorizontal();
		if(GUILayout.Button (inventoryNameDictionary[0].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[0].name != "null")
			{
				for(int i = 0; i < 6; i++)
				{
					if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
					{
						JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[0];
						break;
					}
				}
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[1].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[1].name != "null")
			{
				for(int i = 0; i < 6; i++)
				{
					if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
					{
						JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[1];
						break;
					}
				}
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[2].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[2].name != "null")
			{
				for(int i = 0; i < 6; i++)
				{
					if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
					{
						JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[2];
						break;
					}
				}
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[3].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{

		}
		GUILayout.Button (inventoryNameDictionary[4].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[5].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		GUILayout.Button (inventoryNameDictionary[6].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[7].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[8].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[9].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[10].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[11].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		GUILayout.Button (inventoryNameDictionary[12].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[13].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[14].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[15].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[16].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[17].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		GUILayout.Button (inventoryNameDictionary[18].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[19].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[20].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[21].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[22].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[23].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		GUILayout.Button (inventoryNameDictionary[24].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[25].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[26].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[27].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[28].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[29].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		GUILayout.Button (inventoryNameDictionary[30].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[31].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[32].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[33].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[34].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.Button (inventoryNameDictionary[35].icon, GUILayout.Width (50), GUILayout.Height (50));
		GUILayout.EndHorizontal();

		GUILayout.EndArea ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		if(!InventoryUp)
		{
			if(Input.GetKeyUp (KeyCode.I))
			{
				InventoryUp = true;
				gameObject.GetComponent<MouseLook>().enabled = false;
				gameObject.GetComponent<FPSInputController>().enabled = false;
				transform.Find ("Main Camera").GetComponent<MouseLook>().enabled = false;
			}
		}
		if(InventoryUp)
		{
			if(Input.GetKeyUp(KeyCode.Escape))
			{
				InventoryUp = false;
				gameObject.GetComponent<MouseLook>().enabled = true;
				gameObject.GetComponent<FPSInputController>().enabled = true;
				transform.Find ("Main Camera").GetComponent<MouseLook>().enabled = true;
			}
		}
	
	}
}
