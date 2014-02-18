using UnityEngine;
using System.Collections;

public class MF_TrapScript : MonoBehaviour {

	int trapType;
	int baitType;
	bool deployed;
	GameObject river_poi;
	GameObject hut_poi;

	string capture;

	float distanceToRiver;
	float distanceToHut;

	float totalDist;
	float percentToHut;
	float percentToRiver;

	// Capture weightings based on trap
	float squirrel_weighting;
	float beaver_weighting;

	// Use this for initialization
	void Start () {
		river_poi = GameObject.Find("RiverPOI");
		hut_poi = GameObject.Find("HutPOI");
		capture = "Nothing yet, press wait...";
	}
	
	// Update is called once per frame
	void Update () {
		distanceToRiver = Vector3.Distance(river_poi.transform.position, transform.position);
		distanceToHut = Vector3.Distance(hut_poi.transform.position, transform.position);

		totalDist = distanceToRiver+distanceToHut;
		percentToHut = 100 - (distanceToHut/totalDist)*100;
		percentToRiver = 100 - (distanceToRiver/totalDist)*100;

		if(Input.GetKeyDown ("c") && deployed){
			capture = GetCapture();
			
		}
	}

	public void Deploy(int trap, int bait){
		deployed = true;
		trapType = trap;
		baitType = bait;
	}

	void OnGUI(){
		if(deployed){
			GUI.color = Color.red;
			GUI.Label(new Rect(10, 150,200,200), "You Captured A: ");
			GUI.color = Color.green;
			GUI.Label(new Rect(150, 150,200,200), capture + " 100 points!!");
			GUI.color = Color.red;
		}
		GUI.Label(new Rect(10, 175, 400,200), "river: " + 50.0f*(percentToRiver/100.0f));
		GUI.Label(new Rect(10, 200, 400,200), "hut: " + 50.0f*(percentToHut/100.0f));

		GUI.Label(new Rect(10, 225, 400,200), "......: " + totalDist);
	}

	string GetCapture(){
		
		//Process chances for trap type
		switch(trapType){
			case 1: // Simple box and stick trap
				squirrel_weighting = 50.0f;
				beaver_weighting = 50.0f;	
				break;
		}
		//Process chances for bait type
		switch(baitType){
			case 1: // Berries
				squirrel_weighting = squirrel_weighting*1.5f;
				beaver_weighting = beaver_weighting*0.5f;	
				break;
			case 2: // Berries
				squirrel_weighting = squirrel_weighting*0.2f;
				beaver_weighting = beaver_weighting*1.5f;	
				break;
		}
		//Process Distance Modifier
		float squirrel_chance = squirrel_weighting*(percentToHut/100.0f);
		float beaver_chance = beaver_weighting*(percentToRiver/100.0f);


		float totalChance = squirrel_chance + beaver_chance;

		float rand = Random.Range(0, totalChance);
		Debug.Log("squirrel chance: "+squirrel_chance + " beaver chance: " + beaver_chance + " total chance: "+totalChance+" rand: "+rand);

		if(rand < squirrel_chance){
			Debug.Log("Rand:" + rand + " Caught Squirrel");
			return "Squirrel";
		}
		else if(rand >= squirrel_chance){
			Debug.Log("Rand:" + rand + " Caught Beaver");
			return "Beaver";
		}
		else
			return "ERROR";
	}
}
