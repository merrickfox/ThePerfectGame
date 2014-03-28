using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JP_Looter : MonoBehaviour {
	
	public string ResourceName;

	// Window
	private Rect resourceWindowRect = new Rect(300, 100, 400, 250);
	private bool resourceWindowUp = false;
	public GUISkin looterSkin;
	public Texture2D woodBackground;
	GameObject Player;

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

	public void DisableMovement()
	{
		Player.gameObject.GetComponent<MouseLook>().enabled = false;
		Player.gameObject.transform.Find ("Main Camera").GetComponent<MouseLook>().enabled = false;
		Player.gameObject.GetComponent<FPSInputController>().enabled = false;
		Player.gameObject.GetComponent<CharacterMotor>().enabled = false;
	}
	
	public void EnableMovement()
	{
		Player.gameObject.GetComponent<MouseLook>().enabled = true;
		Player.gameObject.GetComponent<FPSInputController>().enabled = true;
		Player.gameObject.GetComponent<CharacterMotor>().enabled = true;
		Player.gameObject.transform.Find ("Main Camera").GetComponent<MouseLook>().enabled = true;
		
	}

	public void randomLoot ()
	{
		int randNum = Random.Range (0,100);

		// ************************* TUTORIAL RESOURCE ********************************
		// ************************************************************************
		if(ResourceName == "Tutorial Resource")
		{
			looterSkin.window.normal.background = woodBackground;
			looterSkin.window.onNormal.background = woodBackground;

			lootDictionary[0] = itemObject.stick_r;
			lootDictionary[1] = itemObject.box_r;
			lootDictionary[2] = itemObject.nuts_b;
		}

		// ************************* STICK RESOURCE ********************************
		// ************************************************************************
		if(ResourceName == "Stick Resource")
		{
			looterSkin.window.normal.background = woodBackground;
			looterSkin.window.onNormal.background = woodBackground;
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
		}

		// ************************* JUNK RESOURCE ********************************
		// ************************************************************************
		if(ResourceName == "Junk Resource")
		{
			looterSkin.window.normal.background = woodBackground;
			looterSkin.window.onNormal.background = woodBackground;
			if(randNum >= 10)
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
				
			if(randNum >= 20)
			{
				for(int j = 0; j < 4; j++)
				{
					if(lootDictionary[j].name == "null")
					{
						lootDictionary[j] = itemObject.wire_r;
						break;
					}
				}
			}

			if(randNum >= 40)
			{
				for(int j = 0; j < 4; j++)
				{
					if(lootDictionary[j].name == "null")
					{
						lootDictionary[j] = itemObject.needle_r;
						break;
					}
				}
			}
		}

		// ************************* CAR RESOURCE ********************************
		// ************************************************************************
		if(ResourceName == "Car Resource")
		{
			looterSkin.window.normal.background = woodBackground;
			looterSkin.window.onNormal.background = woodBackground;
			if(randNum >= 0)
			{
				for(int j = 0; j < 4; j++)
				{
					if(lootDictionary[j].name == "null")
					{
						lootDictionary[j] = itemObject.cbattery_r;
						break;
					}
				}
			}
			
			if(randNum >= 20)
			{
				for(int j = 0; j < 4; j++)
				{
					if(lootDictionary[j].name == "null")
					{
						lootDictionary[j] = itemObject.wheel_r;
						break;
					}
				}
			}
		}
	}

	// Use this for initialization
	void Start () 
	{
		Player = GameObject.FindGameObjectWithTag ("Player");

		int loopNum = Random.Range (1, 4);
		for(int i = 0; i < loopNum; i++)
		{
			randomLoot();
		}

	}

	void OnGUI()
	{
		if(resourceWindowUp)
		{
			GUI.skin = looterSkin;
			resourceWindowRect = GUI.Window (1, resourceWindowRect, ResourceWindowMethod, "");
		}

	}

	void ResourceWindowMethod(int windowID)
	{
		
		GUILayout.BeginArea (new Rect(5, 50, 390, 400));
		
		GUILayout.BeginHorizontal();
		GUILayout.Space (50f);
		if(GUILayout.Button (lootDictionary[0].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(lootDictionary[0].name != "null")
			{
				for(int i = 0; i < 36; i++)
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
		GUILayout.Space (50f);
		if(GUILayout.Button (lootDictionary[1].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(lootDictionary[1].name != "null")
			{
				for(int i = 0; i < 36; i++)
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
		GUILayout.Space (50f);
		if(GUILayout.Button (lootDictionary[2].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(lootDictionary[2].name != "null")
			{
				for(int i = 0; i < 36; i++)
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
		GUILayout.Space (50f);
		if(GUILayout.Button (lootDictionary[3].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(lootDictionary[3] != null)
			{
				for(int i = 0; i < 36; i++)
				{
					if(JP_InventoryGUI.inventoryNameDictionary[i].name == "null")
					{
						JP_InventoryGUI.inventoryNameDictionary[i] = lootDictionary[3];
						lootDictionary[3] = itemObject.nullItem;
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
				EnableMovement();
			}
		}

		if(resourceWindowUp)
		{
			DisableMovement();
		}
	
	}
}
