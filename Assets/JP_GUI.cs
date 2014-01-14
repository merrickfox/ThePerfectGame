using UnityEngine;
using System.Collections;

public class JP_GUI : MonoBehaviour {

	// Script Variables
	MouseLook Script1;
	CharacterMotor Script2;
	FPSInputController Script3;
	public GameObject Player_Camera;

	// Inventory Variables
	Rect inventorySize =  new Rect (Screen.width/2-150, Screen.height/2, 200, 200);
	Rect stickSize =  new Rect (Screen.width/2+150, Screen.height/2, 200, 200);
	Rect stringSize =  new Rect (Screen.width/2+150, Screen.height/2, 200, 200);
	bool sticks, strings;

	// Window up Variables
	bool inventory_up, stick_up, string_up;

	// Inventory Slots
	bool slot1, slot2, slot3, slot4, slot5;
	bool stick_slots, string_slots;
	string stick_slot_num, string_slot_num;
	Rect slot1_size = new Rect (10,20,50,50);
	Rect slot2_size = new Rect (60,20,50,50);
	Rect slot3_size = new Rect (110,20,50,50);
	Rect slot4_size = new Rect (160,20,50,50);
	Rect slot5_size = new Rect (10,70,50,50);

	Rect stick_slot, string_slot;
	// Pick up Variables
	RaycastHit hit;

	// Resources in resource window
	bool stickResource, stringResource;

	// Texture variables
	public Texture stick_texture, string_texture;

	// GUI Skin
	public GUISkin Window_Skin;

	// Use this for initialization
	void Start () 
	{
		Script1 = GetComponent<MouseLook>();
		Script2 = GetComponent<CharacterMotor>();
		Script3 = GetComponent<FPSInputController>();
	}

	void OnGUI()
	{
		GUI.skin = Window_Skin;
		// Inventory screen
		if (inventory_up) 
		{
			inventorySize = GUI.Window (0, inventorySize, Inventory_Window, "Inventory");
		}
		// Stick Resource Screen
		if (stick_up) 
		{
			stickSize = GUI.Window (1, stickSize, Stick_Window, "Stick Resource Pool");
		}
		// String Window
		if(string_up)
		{
			stringSize = GUI.Window (2, stringSize, String_Window, "String Resource Pool");
		}

		// Looting screen
		if (Physics.SphereCast (transform.position, 0.3f, transform.forward, out hit, 2f)) 
		{
			// Stick Resource
			if (hit.collider.gameObject.tag == "Stick_Resource") 
			{
				if(Input.GetKeyUp (KeyCode.E))
				{
					// Disable movement
					Script1.enabled = false;
					Script2.enabled = false;
					Script3.enabled = false;
					Player_Camera.GetComponent<MouseLook>().enabled = false;

					// Bring up inventory/resource
					inventory_up = true;
					stick_up = true;
				}
			}
			// String Resource
			if (hit.collider.gameObject.tag == "String_Resource") 
			{
				if(Input.GetKeyUp (KeyCode.E))
				{
					// Disable movement
					Script1.enabled = false;
					Script2.enabled = false;
					Script3.enabled = false;
					Player_Camera.GetComponent<MouseLook>().enabled = false;
					
					// Bring up inventory/resource
					inventory_up = true;
					string_up = true;
				}
			}
		}
	}

	// Inventory Window
	void Inventory_Window (int windowID) 
	{
		GUI.DragWindow (new Rect (0,0, 10000, 20));
		if(sticks == true)
		{
			if(GUI.Button(stick_slot, stick_texture))
			{
				sticks = false;
				stick_slots = false;
				print (stick_slot_num);
				if(stick_slot_num == "Slot1")
				{
					slot1 = false;
				}
				if(stick_slot_num == "Slot2")
				{
					slot2 = false;
				}
				if(stick_slot_num == "Slot3")
				{
					slot3 = false;
				}
			}
		}
		if(strings == true)
		{
			if(GUI.Button(string_slot, string_texture))
			{
				strings = false;
				string_slots = false;
				if(string_slot_num == "Slot1")
				{
					slot1 = false;
				}
				if(string_slot_num == "Slot2")
				{
					slot2 = false;
				}
				if(string_slot_num == "Slot3")
				{
					slot3 = false;
				}
			}
		}
	}
	// Stick Window
	void Stick_Window (int windowID) 
	{
		GUI.DragWindow (new Rect (0,0, 10000, 20));
		if(sticks == false)
			if(GUI.Button(new Rect (10,20,50,50), stick_texture))
			{
				sticks = true;
				if((slot1 == false) && (stick_slots == false))
				{
					stick_slot = slot1_size;
					slot1 = true;
					stick_slots = true;
					stick_slot_num = "Slot1";
				}
				if((slot2 == false) && (stick_slots == false))
				{
					stick_slot = slot2_size;
					slot2 = true;
					stick_slots = true;
					stick_slot_num = "Slot2";
				}
				if((slot3 == false) && (stick_slots == false))
				{
					stick_slot = slot3_size;
					slot3 = true;
					stick_slots = true;
					stick_slot_num = "Slot3";
				}
			}
			
		}
	// String Window
	void String_Window (int windowID) 
	{
		GUI.DragWindow (new Rect (0,0, 10000, 20));
		if(strings == false)
			if(GUI.Button(new Rect (10,20,50,50), string_texture))
			{
				strings = true;
				if((slot1 == false) && (string_slots == false))
				{
					string_slot = slot1_size;
					slot1 = true;
					string_slots = true;
					string_slot_num = "Slot1";
			}
				if((slot2 == false) && (string_slots == false))
				{
					string_slot = slot2_size;
					slot2 = true;
					string_slots = true;
					string_slot_num = "Slot2";
				}
				if((slot3 == false) && (string_slots == false))
				{
					string_slot = slot3_size;
					slot3 = true;
					string_slots = true;
					string_slot_num = "Slot3";
				}
			}	
	}
	
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyUp (KeyCode.I)) 
		{
			if(!inventory_up)
			{
				inventory_up = true;
				Script1.enabled = false;
				Script2.enabled = false;
				Script3.enabled = false;
				Player_Camera.GetComponent<MouseLook>().enabled = false;
			}
		}
		if (Input.GetKeyUp (KeyCode.Escape)) 
		{
			if (inventory_up)
				inventory_up = false;
			if(stick_up)
				stick_up = false;
			if(string_up)
				string_up = false;

			Script1.enabled = true;
			Script2.enabled = true;
			Script3.enabled = true;
			Player_Camera.GetComponent<MouseLook>().enabled = true;
		}
		
	}
}
