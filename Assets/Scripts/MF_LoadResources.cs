using UnityEngine;
using System.Collections;

public class MF_LoadResources : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.GetInt("CaughtBeaver");
		PlayerPrefs.GetInt("CaughtSquirrel");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
