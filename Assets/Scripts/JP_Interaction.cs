using UnityEngine;
using System.Collections;

public class JP_Interaction : MonoBehaviour {

	// Pick up Variables
	RaycastHit hit;


	// Use this for initialization
	void Start () 
	{
	
	}

	void OnGUI()
	{
		// Looting screen
		if (Physics.SphereCast (transform.position, 0.3f, transform.forward, out hit, 2f)) 
		{
			// Resource
			if (hit.collider.gameObject.tag == "Resource") 
			{
				if(Input.GetKeyDown (KeyCode.E))
				{

					hit.collider.gameObject.GetComponent<JP_Looter>().EnableLooting();
					gameObject.GetComponent<MouseLook>().enabled = false;
					transform.Find ("Main Camera").GetComponent<MouseLook>().enabled = false;
					gameObject.GetComponent<FPSInputController>().enabled = false;
					gameObject.GetComponent<CharacterMotor>().enabled = false;
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyUp(KeyCode.Escape))
		{
			gameObject.GetComponent<MouseLook>().enabled = true;
			gameObject.GetComponent<FPSInputController>().enabled = true;
			gameObject.GetComponent<CharacterMotor>().enabled = true;
			transform.Find ("Main Camera").GetComponent<MouseLook>().enabled = true;
		}
	
	}
}
