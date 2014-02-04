/*
===========================
Trap ID's
===========================
1 = Box with stick
2 = 
3 =

===========================
Bait ID's
===========================
1 = Berries
2 =
3 =

*/
using UnityEngine;
using System.Collections;

public class MF_EquipTrap : MonoBehaviour {
	bool deployed;
	bool trapOneEquip;
	bool trapTwoEquip;
	public GameObject trapOne;
	public GameObject trapTwo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("1")){
			trapOneEquip = true;
			trapTwoEquip = false;

			trapTwo.GetComponent<MeshRenderer>().enabled = false;
			trapTwo.GetComponent<SphereCollider>().enabled = false;
		}

		if (Input.GetKeyDown ("2")){
			trapTwoEquip = true;
			trapOneEquip = false;

			trapOne.GetComponent<MeshRenderer>().enabled = false;
			trapOne.GetComponent<BoxCollider>().enabled = false;
		}


		if(trapOneEquip && !deployed){
			trapOne.GetComponent<MeshRenderer>().enabled = true;
			trapOne.GetComponent<BoxCollider>().enabled = false;

			if(Input.GetKeyDown ("e")){
				trapOne.GetComponent<Rigidbody>().detectCollisions = true;
				trapOne.GetComponent<BoxCollider>().enabled = true;
				trapOne.GetComponent<Rigidbody>().useGravity = true;
				trapOne.GetComponent<MF_TrapScript>().Deploy(1,1);
				trapOne.transform.parent = null;
				deployed = true;
			}
		}
		

		if(trapTwoEquip && !deployed){
			trapTwo.GetComponent<MeshRenderer>().enabled = true;
			trapTwo.GetComponent<SphereCollider>().enabled = false;
			
			if(Input.GetKeyDown ("e")){
				trapTwo.GetComponent<Rigidbody>().detectCollisions = true;
				trapTwo.GetComponent<SphereCollider>().enabled = true;
				trapTwo.GetComponent<Rigidbody>().useGravity = true;
				trapTwo.transform.parent = null;
				deployed = true;
			}
		}
	}
	
	
}
