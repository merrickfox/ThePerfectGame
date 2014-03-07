using UnityEngine;
using System.Collections;

public class MF_TrapScript : MonoBehaviour {
	private Rect captureWindow;
	public GUISkin MyGUISkin;
	GameObject FPC;
	GameObject sceneController;

	public Texture squirrel;
	public Texture beaver;

	bool caught;
	float width,height;
	int trapType;
	int baitType;
	bool deployed;

	GameObject river_poi;
	GameObject hut_poi;
	GameObject woodsOne_poi;

	string capture;

	float distanceToRiver;
	float distanceToHut;
	float distanceToWoodsOne;

	float totalDist;
	float percentToHut;
	float percentToRiver;
	float percentToWoodsOne;

	// Capture weightings based on trap
	float squirrel_weighting;
	float beaver_weighting;
	float snake_weighting;
	float spider_weighting;

	// Use this for initialization
	void Start () {
		FPC = GameObject.Find("First Person Controller");
		sceneController = GameObject.Find("WoodsController");
		river_poi = GameObject.Find("RiverPOI");
		hut_poi = GameObject.Find("HutPOI");
		woodsOne_poi = GameObject.Find("WoodsOnePOI");
		capture = "Nothing yet, press wait...";
		width = 500;
		height = 400;
		captureWindow = new Rect(Screen.width/2-(width/2), Screen.height/2-(height/2), width, height);
	}
	
	// Update is called once per frame
	void Update () {
		distanceToRiver = Vector3.Distance(river_poi.transform.position, transform.position);
		distanceToHut = Vector3.Distance(hut_poi.transform.position, transform.position);
		distanceToWoodsOne = Vector3.Distance(woodsOne_poi.transform.position, transform.position);

		totalDist = distanceToRiver+distanceToHut+distanceToWoodsOne;

		percentToHut = 100 - (distanceToHut/totalDist)*100;
		percentToRiver = 100 - (distanceToRiver/totalDist)*100;
		percentToWoodsOne = 100 - (distanceToWoodsOne/totalDist)*100;

		if(Input.GetKeyDown ("m") && deployed){
			capture = GetCapture();
			caught = true;
			sceneController.SendMessage("DisplayTrophy", capture);
			
			
		}
	}

	public void Deploy(int trap, int bait){
		deployed = true;
		trapType = trap;
		baitType = bait;
	}

	void OnGUI(){
	
		
		if(caught){
			DisableMovement();
			GUI.skin = MyGUISkin;
			captureWindow = new Rect(captureWindow.x, captureWindow.y, width, height);
			captureWindow = GUILayout.Window(1, captureWindow, DoMyWindow, "Capture", GUI.skin.GetStyle("window"));
		}
	}

	void DisableMovement(){
		FPC.GetComponent<MouseLook>().enabled = false;
		FPC.GetComponent<FPSInputController>().enabled = false;
		FPC.GetComponent<CharacterMotor>().enabled = false;
		FPC.transform.Find ("Main Camera").GetComponent<MouseLook>().enabled = false;
	}

	void EnableMovement(){
		FPC.GetComponent<MouseLook>().enabled = true;
		FPC.GetComponent<FPSInputController>().enabled = true;
		FPC.GetComponent<CharacterMotor>().enabled = true;
		FPC.transform.Find ("Main Camera").GetComponent<MouseLook>().enabled = true;
	}

	string GetCapture(){
		
		//Process chances for trap type
		switch(trapType){
			case 1: // Simple box and stick trap
				squirrel_weighting = 50.0f;
				beaver_weighting = 50.0f;	
				snake_weighting = 50.0f;
				spider_weighting = 50.0f;
				break;
		}

		//Process chances for bait type
		switch(baitType){
			case 1: // Berries
				squirrel_weighting = squirrel_weighting*1.5f;
				beaver_weighting = beaver_weighting*0.5f;
				snake_weighting = snake_weighting*1.0f;
				spider_weighting = spider_weighting*0.5f;
				
				break;
			case 2: // Berries
				squirrel_weighting = squirrel_weighting*0.2f;
				beaver_weighting = beaver_weighting*1.5f;	
				break;
		}
		//Process Distance Modifier
		float squirrel_chance = squirrel_weighting*(percentToHut/100.0f);
		float beaver_chance = beaver_weighting*(percentToRiver/100.0f);
		float snake_chance = snake_weighting*(percentToWoodsOne/100.0f);
		float spider_chance = spider_weighting*(percentToWoodsOne/100.0f);

		float totalChance = squirrel_chance + beaver_chance + snake_chance + spider_chance;

		float rand = Random.Range(0, totalChance);
		Debug.Log("squirrel chance: "+squirrel_chance + " beaver chance: " + beaver_chance + "spider chance: "+spider_chance + " snake chance: " + snake_chance +" total chance: "+totalChance+" rand: "+rand);
		
		//need to find a way to make this neater and work properly
		if(rand < squirrel_chance){
			Debug.Log("Rand:" + rand + " Caught Squirrel");
			return "Squirrel";
		}
		else if(rand >= squirrel_chance && rand < squirrel_chance+beaver_chance){
			Debug.Log("Rand:" + rand + " Caught Beaver");
			return "Beaver";
		}
		else if(rand >= beaver_chance && rand < spider_chance){
			Debug.Log("Rand:" + rand + " Caught Spider");
			return "Spider";
		}
		else if(rand >= snake_chance){
			Debug.Log("Rand:" + rand + " Caught Snake");
			return "Snake";
		}
		else
			return "ERROR";
	}


	void DoMyWindow(int windowID){
    	GUILayout.BeginVertical();
		GUILayout.Box("Congratulations! You caught a..\n"+capture);
		GUILayout.Space(4);
        if(GUILayout.Button("Eat")){
        	caught = false;
        	EnableMovement();
        }
		if(GUILayout.Button("Store In Inventory")){
			caught = false;
			EnableMovement();
		}
       
        GUILayout.EndVertical();
        GUILayout.BeginVertical();
        GUILayout.Space(8);
        //Sliders
        GUILayout.BeginHorizontal();
        GUILayout.EndHorizontal();
        GUILayout.Space(20);
        //Scrollbars
		GUILayout.BeginHorizontal();
		GUILayout.Space(8);
		if(capture == "Squirrel")
			GUILayout.Box(squirrel);
		if(capture == "Beaver")
			GUILayout.Box(beaver);
		GUILayout.EndHorizontal();
		GUILayout.Space(8);
		GUILayout.EndVertical();
        GUI.DragWindow();
    }
}
