using UnityEngine;
using System.Collections;

public class MF_LoadTown : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		 if (Input.GetKey("f12"))
		 	Application.LoadLevel("Loading");
	}
}
