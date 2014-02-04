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
						return itemObject.boxTrap_c;
					}
				}
			}
		}


		return itemObject.nullItem;

	}

}
