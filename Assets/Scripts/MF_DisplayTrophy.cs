using UnityEngine;
using System.Collections;

public class MF_DisplayTrophy : MonoBehaviour {

	public GameObject squirrelTrophy;
	public GameObject beaverTrophy;

	// Use this for initialization
	void Start () {
		squirrelTrophy = GameObject.Find("Squirrel_Trophy");
		squirrelTrophy.GetComponent<MeshRenderer>().enabled = false;

		beaverTrophy = GameObject.Find("Beaver_Trophy");
		beaverTrophy.GetComponent<MeshRenderer>().enabled = false;

		if(PlayerPrefs.GetInt("CaughtSquirrel") == 1){
			squirrelTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtBeaver") == 1){
			beaverTrophy.GetComponent<MeshRenderer>().enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void DisplayTrophy(string trophy){
		if(trophy == "Squirrel"){
			PlayerPrefs.SetInt("CaughtSquirrel",1);
			squirrelTrophy.GetComponent<MeshRenderer>().enabled = true;
		}
		if(trophy == "Beaver"){
			PlayerPrefs.SetInt("CaughtBeaver",1);
			beaverTrophy.GetComponent<MeshRenderer>().enabled = true;
		}
	}
}
