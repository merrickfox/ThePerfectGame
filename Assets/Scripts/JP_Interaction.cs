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

	private Rect trapWindowRect = new Rect(Screen.width/2 - 150, Screen.height/2 - 100, 300, 200);
	private bool trapUp = false;
	public GUISkin trapSkin;
	GameObject sceneController;

	// Test
	GameObject[] Traps;

	void Start()
	{
		sceneController = GameObject.Find("WoodsController");
	}

	void DisableMovement()
	{
		transform.parent.gameObject.GetComponent<MouseLook>().enabled = false;
		transform.parent.gameObject.GetComponent<FPSInputController>().enabled = false;
		transform.parent.gameObject.GetComponent<CharacterMotor>().enabled = false;
		gameObject.GetComponent<MouseLook>().enabled = false;
	}
	
	void EnableMovement()
	{
		transform.parent.gameObject.GetComponent<MouseLook>().enabled = true;
		transform.parent.gameObject.GetComponent<FPSInputController>().enabled = true;
		transform.parent.gameObject.GetComponent<CharacterMotor>().enabled = true;
		gameObject.GetComponent<MouseLook>().enabled = true;
	}

	void OnGUI()
	{
		if (trapUp)
		{
			GUI.skin = trapSkin;
			trapWindowRect = GUI.Window (6, trapWindowRect, trapWindow, "Trap Window");
		}

	}

	void trapWindow(int windowID)
	{
		GUILayout.BeginArea (new Rect(25, 20, 250, 180));

		GUILayout.BeginHorizontal();
		GUILayout.Space(20);
		GUILayout.Label("Your trap hasn't caught anything yet");
		GUILayout.EndHorizontal();

		GUILayout.BeginVertical();
		GUILayout.Space(20);
		GUILayout.EndVertical();

		GUILayout.BeginHorizontal();
		if(GUILayout.Button ("Pickup", GUILayout.Width (120), GUILayout.Height (25)))
		{
			if(hit.collider.gameObject.GetComponent<TrapSettings>().GetCanMove () == true)
			{
				for(int i = 0; i < 36; i++)
				{
					if(JP_InventoryGUI.inventoryNameDictionary[i].name == "null")
					{
						JP_InventoryGUI.inventoryNameDictionary[i] = hit.collider.gameObject.GetComponent<TrapSettings>().GetTrap();
						Destroy (hit.collider.gameObject);
						trapUp = false;
						EnableMovement();
						break;
					}
				}
			}
		}

		GUILayout.Space (10);
		if(GUILayout.Button ("Access Bait", GUILayout.Width (120), GUILayout.Height (25)))
		{
			if(trapObject.GetComponent<JP_SpawnTrap>().isHolding () == false)
			{
				if(hit.collider.gameObject.GetComponent<TrapSettings>().GetBaitWindow() == false)
				{
					hit.collider.gameObject.GetComponent<TrapSettings>().SetBaitWindow(true);
					JP_InventoryGUI.InventoryUp = true;
					JP_InventoryGUI.selectedTrap = hit.collider.gameObject;
					trapUp = false;
				}
			}

		}

		GUILayout.EndHorizontal();
		GUILayout.EndArea ();

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

		if(Input.GetKey ("e") && resourceObject != null){

			hit.collider.gameObject.GetComponent<JP_Looter>().EnableLooting();
		}

		// ******************************** TRAP OBJECTS **********************************************
		// ********************************************************************************************
		if(Input.GetKey ("e") && trapObject != null)
		{
			if(hit.collider.gameObject.GetComponent<TrapSettings>().GetEmpty() == true)
			{
				trapUp = true;

				DisableMovement();
			}
			else if(hit.collider.gameObject.GetComponent<TrapSettings>().GetEmpty () == false)
			{
				if(hit.collider.gameObject.GetComponent<MF_TrapScript>().isCaptured() == false)
					hit.collider.gameObject.GetComponent<MF_TrapScript>().CaptureMethod();
			}
		}

		if(Input.GetKey ("k"))
		{
			Traps = GameObject.FindGameObjectsWithTag("Trap");
				for(int j = 0; j < Traps.Length; j++)
				{
					if(Traps[j] != null)
					{
						if(Traps[j].gameObject.GetComponent<TrapSettings>().GetBait() > 0)
							Traps[j].gameObject.GetComponent<TrapSettings>().SetEmpty(false);
					}
				}
		}

		if(Input.GetKey (KeyCode.Escape))
		{
			if(trapUp == true)
			{
				trapUp = false;
				EnableMovement();
			}
		}
	
	}
	// END OF UPDATE
}
