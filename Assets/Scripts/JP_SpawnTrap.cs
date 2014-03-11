using UnityEngine;
using System.Collections;

public class JP_SpawnTrap : MonoBehaviour 
{
	public GameObject Player;
	bool holdingTrap;

	//Item_Class itemObject = new Item_Class();
	public Item_Class.ItemClass itemObject = new Item_Class.ItemClass();

	// Use this for initialization
	void Start () 
	{
		Player = GameObject.FindGameObjectWithTag("Player");
		gameObject.transform.parent = Player.transform;

		gameObject.GetComponent<Rigidbody>().useGravity = false;
		gameObject.GetComponent<Rigidbody>().detectCollisions = false;

		itemObject = Player.GetComponent<JP_TrapSelection>().GetTrap ();

		holdingTrap = true;
	}

	public void SetItemObject(Item_Class.ItemClass trapObject)
	{
		itemObject = trapObject;
	}

	void Update()
	{
		if(holdingTrap)
		{
			if(Input.GetKeyUp (KeyCode.F))
			{
				gameObject.transform.parent = null;
				gameObject.GetComponent<Rigidbody>().useGravity = true;
				gameObject.GetComponent<Rigidbody>().detectCollisions = true;
				//gameObject.GetComponent<TrapSettings>().SetTrapType (itemObject);
				holdingTrap = false;
			}

			if(Input.GetKeyUp (KeyCode.Escape))
			{
				Debug.Log (itemObject.name);
				for(int i = 0; i < 36; i++)
				{
					if(JP_InventoryGUI.inventoryNameDictionary[i].name == "null")
					{
						JP_InventoryGUI.inventoryNameDictionary[i] = itemObject;
						break;
					}
				}

				holdingTrap = false;
				Destroy (gameObject);
			}
		}

	}
}
