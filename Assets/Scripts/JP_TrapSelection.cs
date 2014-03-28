using UnityEngine;
using System.Collections;

public class JP_TrapSelection : MonoBehaviour 
{
	public GameObject Box_Trap, Cage_Trap, Snare_Trap, Bear_Trap, Rod_Trap, ElectricHuman_Trap, ElectricNet_Trap, Balloon_Trap, Spike_Trap;

	//Item_Class itemObject = new Item_Class();
	public Item_Class.ItemClass itemObject = new Item_Class.ItemClass();

	void Start()
	{


	}

	public GameObject GetTrap(string name)
	{
		if(name == "Box Trap")
		{
			return Box_Trap;
		}

		if(name == "Spike Trap")
		{
			return Spike_Trap;
		}

		if(name == "Bear Trap")
		{
			return Bear_Trap;
		}

		if(name == "Cage Trap")
		{
			return Cage_Trap;
		}

		if(name == "Snare Trap")
		{
			return Snare_Trap;
		}

		if(name == "Human Rod")
		{
			return Rod_Trap;
		}

		if(name == "Electric Net Trap")
		{
			return ElectricNet_Trap;
		}

		if(name == "Electrify Human Trap")
		{
			return ElectricHuman_Trap;
		}

		if(name == "Ballon Trap")
		{
			return Balloon_Trap;
		}


		return null;
	}

	public void SetTrap(Item_Class.ItemClass trapObject)
	{
		itemObject = trapObject;
	}

	public Item_Class.ItemClass GetTrap()
	{
		return itemObject;
	}

}
