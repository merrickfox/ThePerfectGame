using UnityEngine;
using System.Collections;

public class MF_TrapScript : MonoBehaviour {
	Item_Class.ItemClass itemObject = new Item_Class.ItemClass();
	public static Item_Class baitItem = new Item_Class();

	private Rect captureWindow;
	public GUISkin MyGUISkin;
	GameObject FPC;
	GameObject sceneController;

	public GUIText score;
	public Texture squirrel, beaver, spider, mouse, bear, snake, rabbit, deer, skunk, hedgehog, chicken, owl, eagle, pigeon, dog, cat, lizard, raccoon, human;
	

	public Vector3 textLocation;
	bool caught;
	float width,height;
	int trapType;
	int baitType;
	bool deployed;

	GameObject river_poi;
	GameObject hut_poi;
	GameObject woodsOne_poi, bear_poi, beaver_poi, chicken_poi, eagle_poi, hedgehog_poi, lizard_poi, owl_poi, rabbit_poi, skunk_poi, snake_poi, spider_poi, squirrel_poi;

	string capture;

	float distanceToRiver;
	float distanceToHut;
	float distanceToWoodsOne, distanceToBear, distanceToBeaver, distanceToChicken, distanceToEagle, distanceToHedgehog, 
	distanceToLizard, distanceToOwl, distanceToRabbit, distanceToSkunk, distanceToSnake, distanceToSpider, distanceToSquirrel;

	float totalDist;
	float percentToHut;
	float percentToRiver;
	float percentToWoodsOne, percentToBear,  percentToBeaver,  percentToChicken,  percentToEagle,  percentToHedgehog,  percentToLizard, 
	 percentToOwl,  percentToRabbit,  percentToSkunk,  percentToSnake,  percentToSpider,  percentToSquirrel;

	// Capture weightings based on trap
	float squirrel_weighting;
	float beaver_weighting;
	float snake_weighting;
	float spider_weighting;
	float mouse_weighting;
	float bear_weighting;
	float rabbit_weighting;
	float deer_weighting;
	float skunk_weighting;
	float hedgehog_weighting;
	float chicken_weighting;
	float owl_weighting;
	float eagle_weighting;
	float pigeon_weighting;
	float dog_weighting;
	float cat_weighting;
	float lizard_weighting;
	float raccoon_weighting;
	float human_weighting;

	// Use this for initialization
	void Start () {
		FPC = GameObject.Find("First Person Controller");
		//if woods scene
		sceneController = GameObject.Find("WoodsController");
		river_poi = GameObject.Find("RiverPOI");
		hut_poi = GameObject.Find("HutPOI");
		woodsOne_poi = GameObject.Find("WoodsOnePOI");
		bear_poi = GameObject.Find("TrackPOIBear");
		beaver_poi = GameObject.Find("TrackPOIBeaver");
		chicken_poi = GameObject.Find("TrackPOIChicken");
		eagle_poi = GameObject.Find("TrackPOIEagle");
		hedgehog_poi = GameObject.Find("TrackPOIHedgehog");
		lizard_poi = GameObject.Find("TrackPOILizard");
		owl_poi = GameObject.Find("TrackPOIOwl");
		rabbit_poi = GameObject.Find("TrackPOIRabbit");
		skunk_poi = GameObject.Find("TrackPOISkunk");
		snake_poi = GameObject.Find("TrackPOISnake");
		spider_poi = GameObject.Find("TrackPOISpider");
		squirrel_poi = GameObject.Find("TrackPOISquirrel");


		capture = "Nothing yet, press wait...";
		width = 500;
		height = 400;
		captureWindow = new Rect(Screen.width/2-(width/2), Screen.height/2-(height/2), width, height);
	}
	
	// Update is called once per frame
	void Update () {
		//if woods
		distanceToRiver = Vector3.Distance(river_poi.transform.position, transform.position);
		distanceToHut = Vector3.Distance(hut_poi.transform.position, transform.position);
		distanceToWoodsOne = Vector3.Distance(woodsOne_poi.transform.position, transform.position);
		distanceToBear = Vector3.Distance(bear_poi.transform.position, transform.position);
		distanceToBeaver = Vector3.Distance(beaver_poi.transform.position, transform.position);
		distanceToChicken = Vector3.Distance(chicken_poi.transform.position, transform.position);
		distanceToEagle = Vector3.Distance(eagle_poi.transform.position, transform.position);
		distanceToHedgehog = Vector3.Distance(hedgehog_poi.transform.position, transform.position);
		distanceToLizard = Vector3.Distance(lizard_poi.transform.position, transform.position);
		distanceToOwl = Vector3.Distance(owl_poi.transform.position, transform.position);
		distanceToRabbit = Vector3.Distance(rabbit_poi.transform.position, transform.position);
		distanceToSkunk = Vector3.Distance(skunk_poi.transform.position, transform.position);
		distanceToSnake = Vector3.Distance(snake_poi.transform.position, transform.position);
		distanceToSpider = Vector3.Distance(spider_poi.transform.position, transform.position);
		distanceToSquirrel = Vector3.Distance(squirrel_poi.transform.position, transform.position);


		totalDist = distanceToRiver+distanceToHut+distanceToWoodsOne+distanceToBear+distanceToBeaver+distanceToChicken+distanceToEagle+distanceToHedgehog+
		distanceToLizard+distanceToOwl+distanceToRabbit+distanceToSkunk+distanceToSnake+distanceToSpider+distanceToSquirrel;
		//Debug.Log(totalDist);

		percentToWoodsOne = 100 - (distanceToWoodsOne/totalDist)*100;
		percentToHut = 100 - (distanceToHut/totalDist)*100;
		percentToRiver = 100 - (distanceToRiver/totalDist)*100;
		percentToBear = 100 - (distanceToBear/totalDist)*100;
		percentToBeaver = 100 - (distanceToBeaver/totalDist)*100;
		percentToChicken = 100 - (distanceToChicken/totalDist)*100;
		percentToEagle = 100 - (distanceToEagle/totalDist)*100;
		percentToHedgehog = 100 - (distanceToHedgehog/totalDist)*100;
		percentToLizard = 100 - (distanceToLizard/totalDist)*100;
		percentToOwl = 100 - (distanceToOwl/totalDist)*100;
		percentToRabbit = 100 - (distanceToRabbit/totalDist)*100;
		percentToSkunk = 100 - (distanceToSkunk/totalDist)*100;
		percentToSnake = 100 - (distanceToSnake/totalDist)*100;
		percentToSpider = 100 - (distanceToSpider/totalDist)*100;
		percentToSquirrel = 100 - (distanceToSquirrel/totalDist)*100;

		if(Input.GetKeyDown ("m") && deployed){
			capture = GetCapture();
			caught = true;
			sceneController.SendMessage("DisplayTrophy", capture);
		}

		/*if(PlayerPrefs.GetInt ("TrapWait") == 1 && deployed){
			capture = GetCapture();
			caught = true;
			sceneController.SendMessage("DisplayTrophy", capture);
			PlayerPrefs.SetInt ("TrapWait", 0);
			PlayerPrefs.SetInt ("Caught", 1);
		}*/
	}

	public void CaptureMethod()
	{
		capture = GetCapture();
		caught = true;
		sceneController.SendMessage("DisplayTrophy", capture);
	}

	public bool isCaptured()
	{
		return caught;
	}

	public void Deploy(int trap, int bait){
		deployed = true;
		trapType = trap;
		baitType = bait;

		Debug.Log("Bait ID: " + bait + " TrapID: "+ trap);
	}

	void OnGUI(){
	
		GUI.Label(new Rect(10, 10, 100, 40), ((distanceToHut/totalDist)).ToString());
		GUI.Label(new Rect(10, 40, 100, 40), ((distanceToRiver/totalDist)).ToString());
		GUI.Label(new Rect(10, 90, 100, 40), ((distanceToWoodsOne/totalDist)).ToString());
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

	public string GetCapture(){
		
		//Process chances for trap type
		switch(trapType){
			case 1: // Simple box and stick trap
				squirrel_weighting = 50.0f;
				beaver_weighting = 50.0f;	
				snake_weighting = 50.0f;
				spider_weighting  = 50.0f;
				mouse_weighting = 50.0f;
				bear_weighting = 50.0f;
				rabbit_weighting = 50.0f;
				deer_weighting = 50.0f;
				skunk_weighting = 50.0f;
				hedgehog_weighting = 50.0f;
				chicken_weighting = 50.0f;
				owl_weighting = 50.0f;
				eagle_weighting = 50.0f;
				pigeon_weighting = 50.0f;
				dog_weighting = 50.0f;
				cat_weighting = 50.0f;
				lizard_weighting = 50.0f;
				raccoon_weighting = 50.0f;
				human_weighting = 50.0f;

				break;

			case 2: // spike trap
				squirrel_weighting = 50.0f;
				beaver_weighting = 50.0f;	
				snake_weighting = 50.0f;
				spider_weighting  = 50.0f;
				mouse_weighting = 50.0f;
				bear_weighting = 50.0f;
				rabbit_weighting = 50.0f;
				deer_weighting = 50.0f;
				skunk_weighting = 50.0f;
				hedgehog_weighting = 50.0f;
				chicken_weighting = 50.0f;
				owl_weighting = 50.0f;
				eagle_weighting = 50.0f;
				pigeon_weighting = 50.0f;
				dog_weighting = 50.0f;
				cat_weighting = 50.0f;
				lizard_weighting = 50.0f;
				raccoon_weighting = 50.0f;
				human_weighting = 50.0f;

				break;

			case 3: // bear trap
				squirrel_weighting = 50.0f;
				beaver_weighting = 50.0f;	
				snake_weighting = 50.0f;
				spider_weighting  = 50.0f;
				mouse_weighting = 50.0f;
				bear_weighting = 100.0f;
				rabbit_weighting = 50.0f;
				deer_weighting = 50.0f;
				skunk_weighting = 50.0f;
				hedgehog_weighting = 50.0f;
				chicken_weighting = 50.0f;
				owl_weighting = 50.0f;
				eagle_weighting = 50.0f;
				pigeon_weighting = 50.0f;
				dog_weighting = 50.0f;
				cat_weighting = 50.0f;
				lizard_weighting = 50.0f;
				raccoon_weighting = 50.0f;
				human_weighting = 50.0f;

				break;
		}

		//Process chances for bait type
		switch(baitType){
			case 1: // Alcohol
				squirrel_weighting = squirrel_weighting*0f;
				beaver_weighting = beaver_weighting*0f;
				snake_weighting = snake_weighting*0f;
				spider_weighting = spider_weighting*0f;
				mouse_weighting = mouse_weighting*0f;
				bear_weighting = bear_weighting*0f;
				rabbit_weighting = rabbit_weighting*0f;
				deer_weighting = deer_weighting*0f;
				skunk_weighting = skunk_weighting*0f;
				hedgehog_weighting = hedgehog_weighting*0f;
				chicken_weighting = chicken_weighting*0f;
				owl_weighting = owl_weighting*0f;
				eagle_weighting = eagle_weighting*0f;
				pigeon_weighting = pigeon_weighting*0f;
				dog_weighting = dog_weighting*0f;
				cat_weighting = cat_weighting*0f;
				lizard_weighting = lizard_weighting*0f;
				raccoon_weighting = raccoon_weighting*0f;
				human_weighting = human_weighting*1.5f;
				
				break;
			case 2: // Nut
				squirrel_weighting = squirrel_weighting*2.5f;
				beaver_weighting = beaver_weighting*0.5f;
				snake_weighting = snake_weighting*1.0f;
				spider_weighting = spider_weighting*0.5f;
				mouse_weighting = mouse_weighting*1.0f;
				bear_weighting = bear_weighting*0.5f;
				rabbit_weighting = rabbit_weighting*0.5f;
				deer_weighting = deer_weighting*0.5f;
				skunk_weighting = skunk_weighting*0.5f;
				hedgehog_weighting = hedgehog_weighting*0.5f;
				chicken_weighting = chicken_weighting*0.5f;
				owl_weighting = owl_weighting*0.5f;
				eagle_weighting = eagle_weighting*0.5f;
				pigeon_weighting = pigeon_weighting*0.5f;
				dog_weighting = dog_weighting*0.5f;
				cat_weighting = cat_weighting*0.5f;
				lizard_weighting = lizard_weighting*0.5f;
				raccoon_weighting = raccoon_weighting*0.5f;
				human_weighting = human_weighting*0.5f;	
				break;
		}

		float [] chanceIndex = new float [19];
		float [] cumalativeChance = new float [chanceIndex.Length];
		//Process Distance Modifier = final chances
		// seperate these per town/woods
		float squirrel_chance = chanceIndex[0] = squirrel_weighting/(distanceToSquirrel/totalDist);
		float beaver_chance = chanceIndex[1] = beaver_weighting/(distanceToBeaver/totalDist);
		float snake_chance = chanceIndex[2] = snake_weighting/(distanceToSnake/totalDist);
		float spider_chance = chanceIndex[3] = spider_weighting/(distanceToSpider/totalDist);
		float mouse_chance = chanceIndex[4] = mouse_weighting/(distanceToHut/totalDist);
		float bear_chance = chanceIndex[5] = bear_weighting/(distanceToBear/totalDist);
		float rabbit_chance = chanceIndex[6] = rabbit_weighting/(distanceToRabbit/totalDist);
		float deer_chance = chanceIndex[7] = deer_weighting/(distanceToWoodsOne/totalDist);
		float skunk_chance = chanceIndex[8] = skunk_weighting/(distanceToSkunk/totalDist);
		float hedgehog_chance = chanceIndex[9] = hedgehog_weighting/(distanceToHedgehog/totalDist);
		float chicken_chance = chanceIndex[10] = chicken_weighting/(distanceToChicken/totalDist);
		float owl_chance = chanceIndex[11] = owl_weighting/(distanceToOwl/totalDist);
		float eagle_chance = chanceIndex[12] = eagle_weighting/(distanceToEagle/totalDist);
		float pigeon_chance = chanceIndex[13] = pigeon_weighting/(distanceToWoodsOne/totalDist);
		float dog_chance = chanceIndex[14] = dog_weighting/(distanceToHut/totalDist);
		float cat_chance = chanceIndex[15] = cat_weighting/(distanceToHut/totalDist);
		float lizard_chance = chanceIndex[16] = lizard_weighting/(distanceToLizard/totalDist);
		float raccoon_chance = chanceIndex[17] = raccoon_weighting/(distanceToRiver/totalDist);
		float human_chance = chanceIndex[18] = human_weighting/(distanceToRiver/totalDist);
		

		Debug.Log(percentToHut + " " +percentToRiver + " " +percentToWoodsOne  );


		float totalChance = squirrel_chance + beaver_chance + snake_chance + spider_chance + mouse_chance + bear_chance + 
		rabbit_chance + deer_chance + skunk_chance + hedgehog_chance + chicken_chance + owl_chance + eagle_chance + pigeon_chance +
		dog_chance + cat_chance + lizard_chance + raccoon_chance;

		for(int i = 0; i<chanceIndex.Length; i++){
			if(i == 0) cumalativeChance[0] = chanceIndex[0];
			else{ 
				cumalativeChance[i] = chanceIndex[i] + cumalativeChance[i-1];
				//Debug.Log(chanceIndex[i] + " + " +cumalativeChance[i-1]);
			}
			//Debug.Log("total " + cumalativeChance[i]);
		}

		float rand = Random.Range(0, totalChance);
		Debug.Log("squirrel chance: "+squirrel_chance + " beaver chance: " + beaver_chance +  " snake chance: " + snake_chance + " spider chance: "+spider_chance +" total chance: "+totalChance+" rand: "+rand);
		
		//need to find a way to make this neater and work properly
		if(rand < cumalativeChance[0]){
			Debug.Log("Rand:" + rand + " Caught Squirrel");
			return "Squirrel";
		}
		else if(rand >= cumalativeChance[0] && rand < cumalativeChance[1]){
			Debug.Log("Rand:" + rand + " Caught Beaver");
			return "Beaver";
		}
		else if(rand >= cumalativeChance[1] && rand < cumalativeChance[2]){
			Debug.Log("Rand:" + rand + " Caught Snake");
			return "Snake";
		}
		else if(rand >= cumalativeChance[2] && rand < cumalativeChance[3]){
			Debug.Log("Rand:" + rand + " Caught Spider");
			return "Spider";
		}
		else if(rand >= cumalativeChance[3] && rand < cumalativeChance[4]){
			Debug.Log("Rand:" + rand + " Caught Mouse");
			return "Mouse";
		}
		else if(rand >= cumalativeChance[4] && rand < cumalativeChance[5]){
			Debug.Log("Rand:" + rand + " Caught Bear");
			return "Bear";
		}
		else if(rand >= cumalativeChance[5] && rand < cumalativeChance[6]){
			Debug.Log("Rand:" + rand + " Caught Rabbit");
			return "Rabbit";
		}
		else if(rand >= cumalativeChance[6] && rand < cumalativeChance[7]){
			Debug.Log("Rand:" + rand + " Caught Deer");
			return "Deer";
		}
		else if(rand >= cumalativeChance[7] && rand < cumalativeChance[8]){
			Debug.Log("Rand:" + rand + " Caught Skunk");
			return "Skunk";
		}
		else if(rand >= cumalativeChance[8] && rand < cumalativeChance[9]){
			Debug.Log("Rand:" + rand + " Caught Hedgehog");
			return "Hedgehog";
		}
		else if(rand >= cumalativeChance[9] && rand < cumalativeChance[10]){
			Debug.Log("Rand:" + rand + " Caught Chicken");
			return "Chicken";
		}
		else if(rand >= cumalativeChance[10] && rand < cumalativeChance[11]){
			Debug.Log("Rand:" + rand + " Caught Owl");
			return "Owl";
		}
		else if(rand >= cumalativeChance[11] && rand < cumalativeChance[12]){
			Debug.Log("Rand:" + rand + " Caught Eagle");
			return "Eagle";
		}
		else if(rand >= cumalativeChance[12] && rand < cumalativeChance[13]){
			Debug.Log("Rand:" + rand + " Caught Pigeon");

			return "Pigeon";
		}
		else if(rand >= cumalativeChance[13] && rand < cumalativeChance[14]){
			Debug.Log("Rand:" + rand + " Caught Dog");
			return "Dog";
		}
		else if(rand >= cumalativeChance[14] && rand < cumalativeChance[15]){
			Debug.Log("Rand:" + rand + " Caught Cat");
			return "Cat";
		}
		else if(rand >= cumalativeChance[15] && rand < cumalativeChance[16]){
			Debug.Log("Rand:" + rand + " Caught Lizard");
			return "Lizard";
		}
		else if(rand >= cumalativeChance[16] && rand < cumalativeChance[17]){
			Debug.Log("Rand:" + rand + " Caught Raccoon");
			return "Raccoon";
		}
		else if(rand >= cumalativeChance[17] && rand < cumalativeChance[18]){
			Debug.Log("Rand:" + rand + " Caught Human");
			itemObject = baitItem.homeless_b;
			return "Human";
		}
		
		else
			return "ERROR";
	}


	void DoMyWindow(int windowID){
		textLocation = Camera.main.WorldToScreenPoint(transform.position);
		textLocation.x = 0.2f;
		textLocation.y = 0.5f;
		
    	GUILayout.BeginVertical();
		GUILayout.Box("Congratulations! You caught a..\n"+capture);
		GUILayout.Space(4);
        if(GUILayout.Button("Eat")){
        	caught = false;
        	EnableMovement();
        	Instantiate(score, textLocation, Quaternion.identity);
        }
		if(GUILayout.Button("Store In Inventory")){
			caught = false;
			EnableMovement();
			Instantiate(score, textLocation, Quaternion.identity);
			for(int i =0; i<36; i++){
				if(JP_InventoryGUI.inventoryNameDictionary[i].name == "null"){
					JP_InventoryGUI.inventoryNameDictionary[i] = itemObject;
					break;
				}
			}
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
		if(capture == "Spider")
			GUILayout.Box(spider);
		if(capture == "Mouse")
			GUILayout.Box(mouse);
		if(capture == "Bear")
			GUILayout.Box(bear);
		if(capture == "Snake")
			GUILayout.Box(snake);
		if(capture == "Rabbit")
			GUILayout.Box(rabbit);
		if(capture == "Deer")
			GUILayout.Box(deer);
		if(capture == "Skunk")
			GUILayout.Box(skunk);
		if(capture == "Hedgehog")
			GUILayout.Box(hedgehog);
		if(capture == "Chicken")
			GUILayout.Box(chicken);
		if(capture == "Owl")
			GUILayout.Box(owl);
		if(capture == "Eagle")
			GUILayout.Box(eagle);
		if(capture == "Pigeon")
			GUILayout.Box(pigeon);
		if(capture == "Dog")
			GUILayout.Box(dog);
		if(capture == "Cat")
			GUILayout.Box(cat);
		if(capture == "Lizard")
			GUILayout.Box(lizard);
		if(capture == "Raccoon")
			GUILayout.Box(raccoon);
		if(capture == "Human")
			GUILayout.Box(human);

		GUILayout.EndHorizontal();
		GUILayout.Space(8);
		GUILayout.EndVertical();
        GUI.DragWindow();
    }
}
