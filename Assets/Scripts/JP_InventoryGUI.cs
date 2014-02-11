using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JP_InventoryGUI : MonoBehaviour {

	private Rect inventoryWindowRect = new Rect(100,100,400,400);
	private bool InventoryUp = false;

	//Item_Class itemObject = new Item_Class();
	public static Item_Class itemObject = new Item_Class();

	GameObject trapObject;

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
		
		void InventoryWindowMethod(int windowID)
	{
	
		// ****************************** BUTTON LAYOUT AND ACTION ********************************************
		// ****************************************************************************************************
		// ****************************************************************************************************
		GUILayout.BeginArea (new Rect(35, 50, 390, 400));

		GUILayout.BeginHorizontal();
		if(GUILayout.Button (inventoryNameDictionary[0].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[0].isTrap == false)
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

			if(inventoryNameDictionary[0].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[0].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[0]);
				inventoryNameDictionary[0] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[1].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[1].isTrap == false)
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

			if(inventoryNameDictionary[1].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[1].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[1]);
				inventoryNameDictionary[1] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[2].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[2].isTrap == false)
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

			if(inventoryNameDictionary[2].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[2].name);

				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[2]);
				inventoryNameDictionary[2] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[3].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[3].isTrap == false)
			{
				if(inventoryNameDictionary[3].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[3];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[3].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[3].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[3]);
				inventoryNameDictionary[3] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[4].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[4].isTrap == false)
			{
				if(inventoryNameDictionary[4].isTrap == false)
				{
					if(inventoryNameDictionary[4].name != "null")
					{
						for(int i = 0; i < 6; i++)
						{
							if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
							{
								JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[4];
								break;
							}
						}
					}
				}
			}

			if(inventoryNameDictionary[4].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[4].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[4]);
				inventoryNameDictionary[4] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[5].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[5].isTrap == false)
			{
				if(inventoryNameDictionary[5].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[5];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[5].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[5].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[5]);
				inventoryNameDictionary[5] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		if(GUILayout.Button (inventoryNameDictionary[6].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[6].isTrap == false)
			{
				if(inventoryNameDictionary[6].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[6];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[6].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[6].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[6]);
				inventoryNameDictionary[6] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[7].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[7].isTrap == false)
			{
				if(inventoryNameDictionary[7].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[7];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[7].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[7].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[7]);
				inventoryNameDictionary[7] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[8].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[8].isTrap == false)
			{
				if(inventoryNameDictionary[8].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[8];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[8].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[8].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[8]);
				inventoryNameDictionary[8] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[9].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[9].isTrap == false)
			{
				if(inventoryNameDictionary[9].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[9];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[9].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[9].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[9]);
				inventoryNameDictionary[9] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}

		if(GUILayout.Button (inventoryNameDictionary[10].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[10].isTrap == false)
			{
				if(inventoryNameDictionary[10].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[10];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[10].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[10].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[10]);
				inventoryNameDictionary[10] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[11].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[11].isTrap == false)
			{
				if(inventoryNameDictionary[11].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[11];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[11].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[11].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[11]);
				inventoryNameDictionary[11] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		if(GUILayout.Button (inventoryNameDictionary[12].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[12].isTrap == false)
			{
				if(inventoryNameDictionary[12].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[12];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[12].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[12].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[12]);
				inventoryNameDictionary[12] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[13].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[13].isTrap == false)
			{
				if(inventoryNameDictionary[13].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[13];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[13].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[13].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[13]);
				inventoryNameDictionary[13] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[14].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[14].isTrap == false)
			{
				if(inventoryNameDictionary[14].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[14];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[14].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[14].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[14]);
				inventoryNameDictionary[14] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[15].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[15].isTrap == false)
			{
				if(inventoryNameDictionary[15].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[15];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[15].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[15].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[15]);
				inventoryNameDictionary[15] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[16].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[16].isTrap == false)
			{
				if(inventoryNameDictionary[16].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[16];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[16].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[16].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[16]);
				inventoryNameDictionary[16] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[17].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[17].isTrap == false)
			{
				if(inventoryNameDictionary[17].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[17];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[17].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[17].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[17]);
				inventoryNameDictionary[17] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		if(GUILayout.Button (inventoryNameDictionary[18].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[18].isTrap == false)
			{
				if(inventoryNameDictionary[18].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[18];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[18].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[18].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[18]);
				inventoryNameDictionary[18] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[19].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[19].isTrap == false)
			{
				if(inventoryNameDictionary[19].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[19];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[19].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[19].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[19]);
				inventoryNameDictionary[19] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[20].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[20].isTrap == false)
			{
				if(inventoryNameDictionary[20].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[20];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[20].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[20].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[20]);
				inventoryNameDictionary[20] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[21].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[21].isTrap == false)
			{
				if(inventoryNameDictionary[21].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[21];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[21].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[21].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[21]);
				inventoryNameDictionary[21] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[22].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[22].isTrap == false)
			{
				if(inventoryNameDictionary[22].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[22];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[22].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[22].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[22]);
				inventoryNameDictionary[22] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[23].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[23].isTrap == false)
			{
				if(inventoryNameDictionary[23].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[23];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[23].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[23].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[23]);
				inventoryNameDictionary[23] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		if(GUILayout.Button (inventoryNameDictionary[24].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[24].isTrap == false)
			{
				if(inventoryNameDictionary[24].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[24];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[24].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[24].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[24]);
				inventoryNameDictionary[24] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[25].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[25].isTrap == false)
			{
				if(inventoryNameDictionary[25].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[25];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[25].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[25].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[25]);
				inventoryNameDictionary[25] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[26].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[26].isTrap == false)
			{
				if(inventoryNameDictionary[26].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[26];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[26].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[26].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[26]);
				inventoryNameDictionary[26] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[27].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[27].isTrap == false)
			{
				if(inventoryNameDictionary[27].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[27];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[27].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[27].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[27]);
				inventoryNameDictionary[27] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[28].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[28].isTrap == false)
			{
				if(inventoryNameDictionary[28].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[28];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[28].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[28].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[28]);
				inventoryNameDictionary[28] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[29].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[29].isTrap == false)
			{
				if(inventoryNameDictionary[29].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[29];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[29].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[29].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[29]);
				inventoryNameDictionary[29] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		if(GUILayout.Button (inventoryNameDictionary[30].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[30].isTrap == false)
			{
				if(inventoryNameDictionary[30].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[30];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[30].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[30].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[30]);
				inventoryNameDictionary[30] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[31].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[31].isTrap == false)
			{
				if(inventoryNameDictionary[31].name != "null")
				{
					for(int i = 0; i < 6; i++)
					{
						if(JP_FG_CraftingGUI.craftingDictionary[i].name == "null")
						{
							JP_FG_CraftingGUI.craftingDictionary[i] = inventoryNameDictionary[31];
							break;
						}
					}
				}
			}

			if(inventoryNameDictionary[31].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[31].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[31]);
				inventoryNameDictionary[31] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[32].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[2].isTrap == false)
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

			if(inventoryNameDictionary[32].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[32].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[32]);
				inventoryNameDictionary[32] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[33].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[2].isTrap == false)
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

			if(inventoryNameDictionary[33].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[33].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[33]);
				inventoryNameDictionary[33] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[34].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[2].isTrap == false)
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

			if(inventoryNameDictionary[34].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[34].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[34]);
				inventoryNameDictionary[34] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		if(GUILayout.Button (inventoryNameDictionary[35].icon, GUILayout.Width (50), GUILayout.Height (50)))
		{
			if(inventoryNameDictionary[2].isTrap == false)
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

			if(inventoryNameDictionary[35].isTrap == true)
			{
				trapObject = gameObject.GetComponent<JP_TrapSelection>().GetTrap (inventoryNameDictionary[35].name);
				
				Instantiate(trapObject, transform.position + transform.forward * 2, Quaternion.identity);
				gameObject.GetComponent<JP_TrapSelection>().SetTrap (inventoryNameDictionary[35]);
				inventoryNameDictionary[35] = itemObject.nullItem;
				EnableMovement ();
				InventoryUp = false;
			}
		}
		GUILayout.EndHorizontal();

		GUILayout.EndArea ();

		// ************************************** END OF BUTTON LAYOUT AND ACTION **************************************
		// *************************************************************************************************************
		// *************************************************************************************************************

	}
	
	// Update is called once per frame
	void Update () 
	{
		if(!InventoryUp)
		{
			if(Input.GetKeyUp (KeyCode.I))
			{
				InventoryUp = true;
				DisableMovement();
			}
		}
		if(InventoryUp)
		{
			if(Input.GetKeyUp(KeyCode.Escape))
			{
				InventoryUp = false;
				gameObject.GetComponent<MouseLook>().enabled = true;
				gameObject.GetComponent<FPSInputController>().enabled = true;
				gameObject.GetComponent<CharacterMotor>().enabled = true;
				transform.Find ("Main Camera").GetComponent<MouseLook>().enabled = true;
			}
		}
	
	}
}
