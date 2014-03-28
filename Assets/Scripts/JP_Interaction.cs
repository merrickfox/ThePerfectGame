using UnityEngine;
using System.Collections;

public class JP_Interaction : MonoBehaviour {

	// Pick up Variables
	RaycastHit hit;
	GameObject resourceObject;
	GameObject trapObject,otherObject;
	public GUITexture resourceInteraction;
	public GUITexture trapInteraction, otherInteraction;

	float X;
	float Y;


	// Use this for initialization
	void Start () 
	{
	
	}

	void OnGUI()
	{

	}
		
		// Update is called once per frame
	void FixedUpdate () 
	{	
		float distance = 6f;
		// Looting screen
		if (Physics.Raycast (transform.position, transform.forward * distance, out hit)) 
		{	
			Debug.Log(hit.transform.name);
			// ************************************* Resource Object Detection **********************************************************
			// **************************************************************************************************************************
			if (hit.collider.gameObject.tag == "Resource") 
			{
					resourceObject = hit.collider.gameObject;
					resourceInteraction.transform.position = Camera.main.WorldToViewportPoint(resourceObject.transform.position);
					resourceInteraction.gameObject.SetActive(true);
					
			}
			else
			{
				resourceObject = null;
				resourceInteraction.gameObject.SetActive(false);
			}

			// ******************************************* Trap ************************************************************************
			// *************************************************************************************************************************
			if((hit.collider.gameObject.tag == "Trap" ))
			{
				trapObject = hit.collider.gameObject;
				trapInteraction.transform.position = Camera.main.WorldToViewportPoint(trapObject.transform.position);
				trapInteraction.gameObject.SetActive(true);
					
			}
			else
			{
				trapObject = null;
				trapInteraction.gameObject.SetActive(false);
			}

			// ******************************************* Bike ************************************************************************
			// *************************************************************************************************************************
			if((hit.collider.gameObject.tag == "Bike"))
			{
				Debug.Log("Bike");
				otherObject = hit.collider.gameObject;
				otherInteraction.transform.position = Camera.main.WorldToViewportPoint(otherObject.transform.position);
				otherInteraction.gameObject.SetActive(true);
				if(Input.GetKey (KeyCode.E)){
					Application.LoadLevel("Loading");
				}
					
			}
			

			// ******************************************* static trap ************************************************************************
			// *************************************************************************************************************************
			else if((hit.collider.gameObject.tag == "Static Trap"))
			{
				otherObject = hit.collider.gameObject;
				otherInteraction.transform.position = Camera.main.WorldToViewportPoint(otherObject.transform.position);
				otherInteraction.gameObject.SetActive(true);
				if(Input.GetKey (KeyCode.E)){
					//place bait
					Debug.Log("place bait");
				}
					
			}
			else{
				otherObject = null;
				otherInteraction.gameObject.SetActive(false);
			}
		}
		// END OF RAYCAST

		Debug.DrawRay (transform.position, transform.forward * distance);

		// ********************************* RESOURCE OBJECTS *****************************************
		// ********************************************************************************************

		if(Input.GetKey (KeyCode.E) && resourceObject != null){
			PlayerPrefs.SetInt("Resource", 1);
			hit.collider.gameObject.GetComponent<JP_Looter>().EnableLooting();
		}

		// ******************************** TRAP OBJECTS **********************************************
		// ********************************************************************************************
		if(Input.GetKey (KeyCode.E) && trapObject != null)
		{
			if(hit.collider.gameObject.GetComponent<TrapSettings>().GetCanMove () == true)
			{
				Debug.Log ("Picking up");
				for(int i = 0; i < 36; i++)
				{
					if(JP_InventoryGUI.inventoryNameDictionary[i].name == "null")
					{
						JP_InventoryGUI.inventoryNameDictionary[i] = hit.collider.gameObject.GetComponent<TrapSettings>().GetTrap();
						Destroy (hit.collider.gameObject);
						break;
					}
				}
			}
		}

		if(Input.GetKey (KeyCode.F) && trapObject != null && trapObject.GetComponent<JP_SpawnTrap>().isHolding () == false)
		{
			Debug.Log("Opening");
			if(hit.collider.gameObject.GetComponent<TrapSettings>().GetBaitWindow() == false)
			{
				hit.collider.gameObject.GetComponent<TrapSettings>().SetBaitWindow(true);
				JP_InventoryGUI.selectedTrap = hit.collider.gameObject;
			}
		}
	
	}
	// END OF UPDATE
}
