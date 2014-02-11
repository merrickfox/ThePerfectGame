using UnityEngine;
using System.Collections;

public class JP_TrapSelection : MonoBehaviour 
{
	public GameObject Box_Trap, Bow_Trap, Trap_C;

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

		if(name == "Bow")
		{
			return Bow_Trap;
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
