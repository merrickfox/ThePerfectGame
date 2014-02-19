using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JP_FG_Recipes : MonoBehaviour 
{
	//Item_Class itemObject = new Item_Class();
	public static Item_Class itemObject = new Item_Class();

	public static Item_Class.ItemClass GetRecipe()
	{
		//Debug.Log ("CREATING TRAP");
		for(int i = 0; i < 6; i++)
		{
			if(JP_FG_CraftingGUI.craftingDictionary[i].name == "Stick")
			{
				for (int j = 0; j < 6; j++)
				{
					if(JP_FG_CraftingGUI.craftingDictionary[j].name == "Box")
					{
						for (int x = 2; x < 6; x++)
						{
							if(JP_FG_CraftingGUI.craftingDictionary[2].name == "null")
							{
								return itemObject.boxTrap_c;
							}
						}

					}
				}
			}


		}

		for(int i = 0; i < 6; i++)
		{
			if (JP_FG_CraftingGUI.craftingDictionary[i].name == "Stick")
			{
				for (int j = 0; j < 6; j++)
				{
					if (JP_FG_CraftingGUI.craftingDictionary[j].name == "Rock")
					{
						for (int x = 0; x < 6; x++)
						{
							if (JP_FG_CraftingGUI.craftingDictionary[x].name == "Leaf")
							{
								for (int z = 3; z < 6; z++)
								{
									if (JP_FG_CraftingGUI.craftingDictionary[3].name == "null")
									{
										return itemObject.spikeTrap_c;
									}
								}
							}
						}
					}
				}
			}
		}

		return itemObject.nullItem;

	}

}
