using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JP_Looter : MonoBehaviour {
	
	public string ResourceName;

	// Window
	private Rect resourceWindowRect = new Rect(300, 100, 400, 400);
	private bool resourceWindowUp = false;

	public static Item_Class itemObject = new Item_Class();

	private Dictionary<int, Item_Class.ItemClass> lootDictionary = new Dictionary<int, Item_Class.ItemClass>()
	{
		{0, itemObject.nullItem},
		{1, itemObject.nullItem},
		{2, itemObject.nullItem},
		{3, itemObject.nullItem}
	};

	// Enable Looting
	public void EnableLooting()
	{
		resourceWindowUp = true;
	}

	public void DisableLooting()
	{
		if(resourceWindowUp)
		{
			resourceWindowUp = false;
		}
	}

	public void randomLoot ()
	{
		int randNum = Random.Range (0,100);

		if(ResourceName == "Stick Resource")
		{
			if(randNum >= 0)
			{
				for(int j = 0; j < 4; j++)
				{
					if(lootDictionary[j].name == "null")
					{
						lootDictionary[j] = itemObject.stick_r;
						break;
					}
				}
			}

			if(randNum >= 0)
			{
				for(int j = 0; j < 4; j++)
				{
					if(lootDictionary[j].name == "null")
					{
						lootDictionary[j] = itemObject.box_r;
						break;
					}
				}
			}

			if(randNum >= 101)
			{
				for(int j = 0; j < 4; j++)
				{
					if(lootDictionary[j].name == "null")
					{
						lootDictionary[j] = itemObject.leaf_r;
						break;
					}
				}
			}

			if(randNum >= 101)
			{
				for(int j = 0; j < 4; j++)
				{
					if(lootDictionary[j].name == "null")
					{
						lootDictionary[j] = itemObject.rock_r;
						break;
					}
				}
			}
		}
	}

	// Use this for initialization
	void Start () 
	{
		randomLoot ();
		

	}

	void OnGUI()
	{
		if(resourceWindowUp)
		{
			resourceWindowRect = GUI.Window (1, resourceWindowRect, ResourceWindowMethod, ResourceName);
		}

	}

	void ResourceWindowMethod(int windowID)
	{
		
		GUILayout.BeginArea (new Rect(5, 50, 390, 400));
		
		GUILayout.BeginHorizontal();
		if(GUILayout.Button (lootDictionary[0].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(lootDictionary[0].name != "null")
			{
				for(int i = 0; i < 9; i++)
				{
					if(JP_InventoryGUI.inventoryNameDictionary[i].name == "null")
					{
						JP_InventoryGUI.inventoryNameDictionary[i] = lootDictionary[0];
						lootDictionary[0] = itemObject.nullItem;
						break;
					}
				}
			}

		}
		if(GUILayout.Button (lootDictionary[1].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(lootDictionary[1].name != "null")
			{
				for(int i = 0; i < 9; i++)
				{
					if(JP_InventoryGUI.inventoryNameDictionary[i].name == "null")
					{
						JP_InventoryGUI.inventoryNameDictionary[i] = lootDictionary[1];
						lootDictionary[1] = itemObject.nullItem;
						break;
					}
				}
			}
		}
		if(GUILayout.Button (lootDictionary[2].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(lootDictionary[2].name != "null")
			{
				for(int i = 0; i < 9; i++)
				{
					if(JP_InventoryGUI.inventoryNameDictionary[i].name == "null")
					{
						JP_InventoryGUI.inventoryNameDictionary[i] = lootDictionary[2];
						lootDictionary[2] = itemObject.nullItem;
						break;
					}
				}
			}
		}
		GUILayout.EndHorizontal();
		
		GUILayout.BeginHorizontal();
		if(GUILayout.Button (lootDictionary[3].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(lootDictionary[3] != null)
			{
				for(int i = 0; i < 9; i++)
				{
					if(JP_InventoryGUI.inventoryNameDictionary[i] == null)
					{
						JP_InventoryGUI.inventoryNameDictionary[i] = lootDictionary[3];
						lootDictionary[3] = null;
						break;
					}
				}
			}
		}
		GUILayout.EndHorizontal();
		
		GUILayout.EndArea ();
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown (KeyCode.Escape))
		{
			if(resourceWindowUp)
			{
				resourceWindowUp = false;
			}
		}
	
	}
}
