using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JP_FG_Recipes : MonoBehaviour 
{
	//Item_Class itemObject = new Item_Class();
	public static Item_Class itemObject = new Item_Class();

	public static Item_Class.ItemClass GetRecipe()
	{
		//Creating a Box Trap
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

		//Spike Trap
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

		//Bear Trap
		for(int i = 0; i < 6; i++)
		{
			if (JP_FG_CraftingGUI.craftingDictionary[i].name == "Scrap Metal")
			{
				for(int j = 0; j < 6; j++)
				{
					if (JP_FG_CraftingGUI.craftingDictionary[j].name == "Wheel")
					{
						for(int x = 2; x < 6; x++)
						{
							if (JP_FG_CraftingGUI.craftingDictionary[2].name == "null")
							{
								return itemObject.bearTrap_c;
							}
						}
					}
				}
			}
		}

		//Cage Trap
		for(int i = 0; i < 6; i++)
		{
			if (JP_FG_CraftingGUI.craftingDictionary[i].name == "Wire")
			{
				for (int j = 0; j < 6; j++)
				{
					if (JP_FG_CraftingGUI.craftingDictionary[j].name == "Knife")
					{
						for (int x = 0; x < 6; x++)
						{
							if (JP_FG_CraftingGUI.craftingDictionary[x].name == "String")
							{
								for (int z = 3; z < 6; z++)
								{
									if (JP_FG_CraftingGUI.craftingDictionary[3].name == "null")
									{
										return itemObject.cageTrap_c;
									}
								}
							}
						}
					}
				}
			}
		}

		//Snare Trap
		for(int i = 0; i < 6; i++)
		{
			if (JP_FG_CraftingGUI.craftingDictionary[i].name == "Rope")
			{
				for (int j = 0; j < 6; j++)
				{
					if (JP_FG_CraftingGUI.craftingDictionary[j].name == "Leaf")
					{
						for (int x = 2; x < 6; x++)
						{
							if (JP_FG_CraftingGUI.craftingDictionary[2].name == "null")
							{
								return itemObject.snareTrap_c;
							}
						}
					}
				}
			}
		}

		//Human Rod
		for(int i = 0; i < 6; i++)
		{
			if (JP_FG_CraftingGUI.craftingDictionary[i].name == "Broken Fishing Rod")
			{
				for(int j = 0; j < 6; j++)
				{
					if (JP_FG_CraftingGUI.craftingDictionary[j].name == "String")
					{
						for (int x = 2; x < 6; x++)
						{
							if (JP_FG_CraftingGUI.craftingDictionary[2].name == "null")
							{
								return itemObject.Rod_c;
							}
						}
					}
				}
			}
		}

		//Electric Human Trap
		for(int i = 0; i < 6; i++)
		{
			if (JP_FG_CraftingGUI.craftingDictionary[i].name == "Wire")
			{
				for (int j = 0; j < 6; j++)
				{
					if (JP_FG_CraftingGUI.craftingDictionary[j].name == "Knife")
					{
						for (int x = 0; x < 6; x++)
						{
							if (JP_FG_CraftingGUI.craftingDictionary[x].name == "String")
							{
								for (int z = 0; z < 6; z++)
								{
									if (JP_FG_CraftingGUI.craftingDictionary[z].name == "Car Battery")
									{
										for (int w = 0; w < 6; w++)
										{
											if (JP_FG_CraftingGUI.craftingDictionary[w].name == "Clothes Hanger")
											{
												for (int t = 5; t < 6; t++)
												{
													if (JP_FG_CraftingGUI.craftingDictionary[5].name == "null")
													{
														return itemObject.electricHuman_c;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		//Balloon Trap
		for(int i = 0; i < 6; i++)
		{
			if (JP_FG_CraftingGUI.craftingDictionary[i].name == "Balloon")
			{
				for (int j = 0; j <6; j++)
				{
					if (JP_FG_CraftingGUI.craftingDictionary[j].name == "String")
					{
						for (int x = 0; x < 6; x++)
						{
							if (JP_FG_CraftingGUI.craftingDictionary[x].name == "Needle")
							{
								for (int t = 3; t < 6; t++)
								{
									if (JP_FG_CraftingGUI.craftingDictionary[3].name == "null")
									{
										return itemObject.balloonTrap_c;
									}
								}
							}
						}
					}
				}
			}
		}

		//Electric Net Trap
		for(int i = 0; i < 6; i++)
		{
			if (JP_FG_CraftingGUI.craftingDictionary[i].name == "Net")
			{
				for (int j = 0; j < 6; j++)
				{
					if (JP_FG_CraftingGUI.craftingDictionary[j].name == "Car Battery")
					{
						for (int x = 2; x < 6; x++)
						{
							if (JP_FG_CraftingGUI.craftingDictionary[2].name == "null")
							{
								return itemObject.electricNetTrap_c;
							}
						}
					}
				}
			}
		}

		return itemObject.nullItem;

	}

}
