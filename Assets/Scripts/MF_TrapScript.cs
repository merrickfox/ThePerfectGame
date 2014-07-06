//need to add the chances for each trap/bait

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
	public Texture squirrel, beaver, spider, mouse, bear, snake, rabbit, deer, skunk, hedgehog, chicken, owl, 
	eagle, pigeon, dog, cat, lizard, raccoon, banker, goth, mayor, druggy, whore, priest, drunk, homeless, pharmacist, binman;
	

	public Vector3 textLocation;
	bool caught;
	float width,height;
	int trapType;
	int baitType;
	bool deployed;
	float rand;
	float [] cumalativeChance;

	GameObject river_poi;
	GameObject hut_poi;
	GameObject woodsOne_poi, bear_poi, beaver_poi, chicken_poi, eagle_poi, hedgehog_poi, lizard_poi, owl_poi, rabbit_poi, skunk_poi, snake_poi, spider_poi, squirrel_poi;
	GameObject banker_poi, binman_poi, cat_poi, dog_poi, druggy_poi, drunk_poi, goth_poi, homeless_poi, mayor_poi, pharmacist_poi, pigeon_poi, priest_poi, whore_poi;
	string capture;

	float distanceToRiver;
	float distanceToHut;
	float distanceToWoodsOne, distanceToBear, distanceToBeaver, distanceToChicken, distanceToEagle, distanceToHedgehog, 
	distanceToLizard, distanceToOwl, distanceToRabbit, distanceToSkunk, distanceToSnake, distanceToSpider, distanceToSquirrel;

	float distanceToBanker, distanceToBinman, distanceToCat, distanceToDog, distanceToDruggy, distanceToGoth, distanceToDrunk,
	distanceToHomeless, distanceToMayor, distanceToPharmacist, distanceToPigeon, distanceToPriest, distanceToWhore;

	float totalDist;
	float percentToHut;
	float percentToRiver;
	float percentToWoodsOne, percentToBear,  percentToBeaver,  percentToChicken,  percentToEagle,  percentToHedgehog,  percentToLizard, 
	 percentToOwl,  percentToRabbit,  percentToSkunk,  percentToSnake,  percentToSpider,  percentToSquirrel;

	 float percentToBanker, percentToBinman,  percentToCat,  percentToDog,  percentToDruggy,  percentToDrunk,  percentToGoth, 
	 percentToHomeless,  percentToMayor,  percentToPharmacist,  percentToPigeon,  percentToPriest,  percentToWhore;


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

	float goth_weighting;
	float mayor_weighting;
	float druggy_weighting;
	float whore_weighting;
	float priest_weighting;
	float drunk_weighting;
	float homeless_weighting;
	float pharmacist_weighting;
	float banker_weighting;
	float binman_weighting;
	

	// Use this for initialization
	void Start () {
		Debug.Log("Leve: " + Application.loadedLevel);
		FPC = GameObject.Find("First Person Controller");
		if(Application.loadedLevel == 1){
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
		}
	//GameObject banker_poi, binman_poi, cat_poi, dog_poi, druggy_poi, drunk_poi, goth_poi, homeless_poi, mayor_poi, pharmacist_poi, pigeon_poi, priest_poi, whore_poi;

		if(Application.loadedLevel == 3){
			sceneController = GameObject.Find("WoodsController");
			banker_poi = GameObject.Find("TrackPOIBanker");
			binman_poi = GameObject.Find("TrackPOIBinman");
			cat_poi = GameObject.Find("TrackPOICat");
			dog_poi = GameObject.Find("TrackPOIDog");
			druggy_poi = GameObject.Find("TrackPOIDruggy");
			drunk_poi = GameObject.Find("TrackPOIDrunk");
			goth_poi = GameObject.Find("TrackPOIGoth");
			homeless_poi = GameObject.Find("TrackPOIHomeless");
			pharmacist_poi = GameObject.Find("TrackPOIPharmacist");
			pigeon_poi = GameObject.Find("TrackPOIPigeon");
			priest_poi = GameObject.Find("TrackPOIPriest");
			whore_poi = GameObject.Find("TrackPOIWhore");
			mayor_poi = GameObject.Find("TrackPOIMayor");
		}


		capture = "Nothing yet, press wait...";
		width = 500;
		height = 400;
		captureWindow = new Rect(Screen.width/2-(width/2), Screen.height/2-(height/2), width, height);
	}
	
	// Update is called once per frame
	void Update () {
		//if woods
		if(Application.loadedLevel == 1){
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
		}

		if(Application.loadedLevel == 3){
			distanceToBanker = Vector3.Distance(banker_poi.transform.position, transform.position);
			distanceToBinman = Vector3.Distance(binman_poi.transform.position, transform.position);
			distanceToCat = Vector3.Distance(cat_poi.transform.position, transform.position);
			distanceToDog = Vector3.Distance(dog_poi.transform.position, transform.position);
			distanceToDruggy = Vector3.Distance(druggy_poi.transform.position, transform.position);
			distanceToDrunk = Vector3.Distance(drunk_poi.transform.position, transform.position);
			distanceToGoth = Vector3.Distance(goth_poi.transform.position, transform.position);
			distanceToHomeless = Vector3.Distance(homeless_poi.transform.position, transform.position);
			distanceToMayor = Vector3.Distance(mayor_poi.transform.position, transform.position);
			distanceToPharmacist = Vector3.Distance(pharmacist_poi.transform.position, transform.position);
			distanceToPigeon = Vector3.Distance(pigeon_poi.transform.position, transform.position);
			distanceToPriest = Vector3.Distance(priest_poi.transform.position, transform.position);
			distanceToWhore = Vector3.Distance(whore_poi.transform.position, transform.position);
			


			totalDist = distanceToBanker+distanceToBinman+distanceToCat+distanceToDog+distanceToDruggy+distanceToDrunk+distanceToGoth+distanceToHomeless+
			distanceToMayor+distanceToPharmacist+distanceToPigeon+distanceToPriest+distanceToWhore;
			//Debug.Log(totalDist);

			percentToBanker = 100 - (distanceToBanker/totalDist)*100;
			percentToBinman = 100 - (distanceToBinman/totalDist)*100;
			percentToCat = 100 - (distanceToCat/totalDist)*100;
			percentToDog = 100 - (distanceToDog/totalDist)*100;
			percentToDruggy = 100 - (distanceToDruggy/totalDist)*100;
			percentToDrunk = 100 - (distanceToDrunk/totalDist)*100;
			percentToGoth = 100 - (distanceToGoth/totalDist)*100;
			percentToHomeless = 100 - (distanceToHomeless/totalDist)*100;
			percentToMayor = 100 - (distanceToMayor/totalDist)*100;
			percentToPharmacist = 100 - (distanceToPharmacist/totalDist)*100;
			percentToPigeon = 100 - (distanceToPigeon/totalDist)*100;
			percentToPriest = 100 - (distanceToPriest/totalDist)*100;
			percentToWhore = 100 - (distanceToWhore/totalDist)*100;
			
		}

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
		if(Application.loadedLevel == 1)
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
	
		//GUI.Label(new Rect(10, 10, 100, 40), ((distanceToHut/totalDist)).ToString());
		//GUI.Label(new Rect(10, 40, 100, 40), ((distanceToRiver/totalDist)).ToString());
		//GUI.Label(new Rect(10, 90, 100, 40), ((distanceToWoodsOne/totalDist)).ToString());
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
				if(Application.loadedLevel == 1){
					squirrel_weighting = 50.0f;
					beaver_weighting = 50.0f;	
					snake_weighting = 50.0f;
					spider_weighting  = 50.0f;
					mouse_weighting = 50.0f;
					bear_weighting = 5.0f;
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
				}
				if(Application.loadedLevel == 3){
					goth_weighting = 0.0f;
					mayor_weighting = 0.0f;
					druggy_weighting = 0.0f;
					whore_weighting = 0.0f;
					priest_weighting = 0.0f;
					drunk_weighting = 0.0f;
					homeless_weighting = 0.0f;
					pharmacist_weighting = 0.0f;
					banker_weighting = 0.0f;
					binman_weighting = 0.0f;
					cat_weighting = 50.0f;
					dog_weighting = 50.0f;
					pigeon_weighting = 50.0f;
				}
				break;

			case 2: // spike trap
				if(Application.loadedLevel == 1){
					squirrel_weighting = 50.0f;
					beaver_weighting = 50.0f;	
					snake_weighting = 50.0f;
					spider_weighting  = 0.0f;
					mouse_weighting = 50.0f;
					bear_weighting = 50.0f;
					rabbit_weighting = 50.0f;
					deer_weighting = 50.0f;
					skunk_weighting = 50.0f;
					hedgehog_weighting = 50.0f;
					chicken_weighting = 50.0f;
					owl_weighting = 0.0f;
					eagle_weighting = 0.0f;
					pigeon_weighting = 0.0f;
					dog_weighting = 50.0f;
					cat_weighting = 50.0f;
					lizard_weighting = 0.0f;
					raccoon_weighting = 50.0f;
					human_weighting = 50.0f;
				}
				if(Application.loadedLevel == 3){
					goth_weighting = 50.0f;
					mayor_weighting = 50.0f;
					druggy_weighting = 75.0f;
					whore_weighting = 50.0f;
					priest_weighting = 50.0f;
					drunk_weighting = 75.0f;
					homeless_weighting = 50.0f;
					pharmacist_weighting = 50.0f;
					banker_weighting = 50.0f;
					binman_weighting = 50.0f;
					cat_weighting = 50.0f;
					dog_weighting = 50.0f;
				}
				break;

			case 3: // bear trap
				if(Application.loadedLevel == 1){
					squirrel_weighting = 50.0f;
					beaver_weighting = 50.0f;	
					snake_weighting = 0.0f;
					spider_weighting  = 50.0f;
					mouse_weighting = 0.0f;
					bear_weighting = 100.0f;
					rabbit_weighting = 50.0f;
					deer_weighting = 50.0f;
					skunk_weighting = 50.0f;
					hedgehog_weighting = 0.0f;
					chicken_weighting = 50.0f;
					owl_weighting = 0.0f;
					eagle_weighting = 0.0f;
					pigeon_weighting = 0.0f;
					dog_weighting = 50.0f;
					cat_weighting = 50.0f;
					lizard_weighting = 0.0f;
					raccoon_weighting = 50.0f;
					
				}
				if(Application.loadedLevel == 3){
					goth_weighting = 50.0f;
					mayor_weighting = 50.0f;
					druggy_weighting = 50.0f;
					whore_weighting = 50.0f;
					priest_weighting = 50.0f;
					drunk_weighting = 50.0f;
					homeless_weighting = 50.0f;
					pharmacist_weighting = 50.0f;
					banker_weighting = 50.0f;
					binman_weighting = 50.0f;
					cat_weighting = 50.0f;
					dog_weighting = 50.0f;
				}

				break;

			case 4: // cage trap
				if(Application.loadedLevel == 1){
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
					
				}
				if(Application.loadedLevel == 3){
					goth_weighting = 50.0f;
					mayor_weighting = 50.0f;
					druggy_weighting = 50.0f;
					whore_weighting = 50.0f;
					priest_weighting = 50.0f;
					drunk_weighting = 50.0f;
					homeless_weighting = 50.0f;
					pharmacist_weighting = 50.0f;
					banker_weighting = 50.0f;
					binman_weighting = 50.0f;
					cat_weighting = 50.0f;
					dog_weighting = 50.0f;
				}

				break;

			case 5: // snare trap
				if(Application.loadedLevel == 1){
					squirrel_weighting = 50.0f;
					beaver_weighting = 50.0f;	
					snake_weighting = 0.0f;
					spider_weighting  = 0.0f;
					mouse_weighting = 50.0f;
					bear_weighting = 50.0f;
					rabbit_weighting = 50.0f;
					deer_weighting = 50.0f;
					skunk_weighting = 50.0f;
					hedgehog_weighting = 50.0f;
					chicken_weighting = 50.0f;
					owl_weighting = 0.0f;
					eagle_weighting = 0.0f;
					pigeon_weighting = 0.0f;
					dog_weighting = 50.0f;
					cat_weighting = 50.0f;
					lizard_weighting = 50.0f;
					raccoon_weighting = 50.0f;
					
				}
				if(Application.loadedLevel == 3){
					goth_weighting = 50.0f;
					mayor_weighting = 50.0f;
					druggy_weighting = 50.0f;
					whore_weighting = 50.0f;
					priest_weighting = 50.0f;
					drunk_weighting = 50.0f;
					homeless_weighting = 50.0f;
					pharmacist_weighting = 50.0f;
					banker_weighting = 50.0f;
					binman_weighting = 50.0f;
					cat_weighting = 50.0f;
					dog_weighting = 50.0f;
				}

				break;

			case 6: // rod trap
				if(Application.loadedLevel == 1){
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
					
				}
				if(Application.loadedLevel == 3){
					goth_weighting = 50.0f;
					mayor_weighting = 50.0f;
					druggy_weighting = 100.0f;
					whore_weighting = 50.0f;
					priest_weighting = 50.0f;
					drunk_weighting = 100.0f;
					homeless_weighting = 100.0f;
					pharmacist_weighting = 50.0f;
					banker_weighting = 50.0f;
					binman_weighting = 50.0f;
					cat_weighting = 50.0f;
					dog_weighting = 50.0f;
					pigeon_weighting = 50.0f;
				}

				break;

			case 7: // electrified cage
				if(Application.loadedLevel == 1){
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
					
				}
				if(Application.loadedLevel == 3){
					goth_weighting = 50.0f;
					mayor_weighting = 50.0f;
					druggy_weighting = 50.0f;
					whore_weighting = 50.0f;
					priest_weighting = 50.0f;
					drunk_weighting = 50.0f;
					homeless_weighting = 50.0f;
					pharmacist_weighting = 50.0f;
					banker_weighting = 50.0f;
					binman_weighting = 50.0f;
					cat_weighting = 50.0f;
					dog_weighting = 50.0f;
					pigeon_weighting = 50.0f;
				}

				break;

			case 8: // electrified net
				if(Application.loadedLevel == 1){
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
					
				}
				if(Application.loadedLevel == 3){
					goth_weighting = 50.0f;
					mayor_weighting = 50.0f;
					druggy_weighting = 50.0f;
					whore_weighting = 50.0f;
					priest_weighting = 50.0f;
					drunk_weighting = 50.0f;
					homeless_weighting = 50.0f;
					pharmacist_weighting = 50.0f;
					banker_weighting = 50.0f;
					binman_weighting = 50.0f;
					cat_weighting = 50.0f;
					dog_weighting = 50.0f;
				}

				break;

			case 9: // baloon trap
				if(Application.loadedLevel == 1){
					squirrel_weighting = 0.0f;
					beaver_weighting = 0.0f;	
					snake_weighting = 0.0f;
					spider_weighting  = 0.0f;
					mouse_weighting = 0.0f;
					bear_weighting = 50.0f;
					rabbit_weighting = 0.0f;
					deer_weighting = 0.0f;
					skunk_weighting = 0.0f;
					hedgehog_weighting = 0.0f;
					chicken_weighting = 0.0f;
					owl_weighting = 0.0f;
					eagle_weighting = 0.0f;
					pigeon_weighting = 0.0f;
					dog_weighting = 0.0f;
					cat_weighting = 0.0f;
					lizard_weighting = 0.0f;
					raccoon_weighting = 0.0f;
					
				}
				if(Application.loadedLevel == 3){
					goth_weighting = 50.0f;
					mayor_weighting = 50.0f;
					druggy_weighting = 50.0f;
					whore_weighting = 50.0f;
					priest_weighting = 50.0f;
					drunk_weighting = 50.0f;
					homeless_weighting = 50.0f;
					pharmacist_weighting = 50.0f;
					banker_weighting = 50.0f;
					binman_weighting = 50.0f;
					cat_weighting = 0.0f;
					dog_weighting = 0.0f;
				}

				break;


		}

		//Process chances for bait type
		switch(baitType){
			case 1: // Alcohol
				if(Application.loadedLevel == 1){
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
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*2f;
					whore_weighting = whore_weighting*2f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*3f;
					homeless_weighting = homeless_weighting*2f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*1.5f;
					dog_weighting = dog_weighting*0f;
					cat_weighting = cat_weighting*0f;
				}	
				
				break;
			case 2: // Nut
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1.5f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*0f;
					spider_weighting = spider_weighting*0f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*0f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*0f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*0f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*0f;
					dog_weighting = dog_weighting*0f;
					cat_weighting = cat_weighting*0f;
					lizard_weighting = lizard_weighting*0f;
					raccoon_weighting = raccoon_weighting*0f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*1f;
					whore_weighting = whore_weighting*1.5f;
					priest_weighting = priest_weighting*1f;
					drunk_weighting = drunk_weighting*1f;
					homeless_weighting = homeless_weighting*1f;
					pharmacist_weighting = pharmacist_weighting*1f;
					banker_weighting = banker_weighting*1f;
					binman_weighting = binman_weighting*1f;
					dog_weighting = dog_weighting*0f;
					cat_weighting = cat_weighting*0f;
				}		
				break;

			case 3: // spider
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*1f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*1f;
					mayor_weighting = mayor_weighting*1f;
					druggy_weighting = druggy_weighting*1f;
					whore_weighting = whore_weighting*1f;
					priest_weighting = priest_weighting*1f;
					drunk_weighting = drunk_weighting*1f;
					homeless_weighting = homeless_weighting*1f;
					pharmacist_weighting = pharmacist_weighting*1f;
					banker_weighting = banker_weighting*1f;
					binman_weighting = binman_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 4: // squirrell
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*1f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*0f;
					cat_weighting = cat_weighting*0f;
				}		
				break;

			case 6: // beaver
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*1f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*0f;
					cat_weighting = cat_weighting*0f;
				}		
				break;

			case 7: // mouse
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*1f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*0f;
					cat_weighting = cat_weighting*0f;
				}		
				break;

			case 8: // bear
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*1f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*1f;
					mayor_weighting = mayor_weighting*1f;
					druggy_weighting = druggy_weighting*1f;
					whore_weighting = whore_weighting*1f;
					priest_weighting = priest_weighting*1f;
					drunk_weighting = drunk_weighting*1f;
					homeless_weighting = homeless_weighting*1f;
					pharmacist_weighting = pharmacist_weighting*1f;
					banker_weighting = banker_weighting*1f;
					binman_weighting = binman_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 9: // carrots
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*0f;
					spider_weighting = spider_weighting*0f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*0f;
					rabbit_weighting = rabbit_weighting*3f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*0f;
					chicken_weighting = chicken_weighting*0f;
					owl_weighting = owl_weighting*0f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*0f;
					dog_weighting = dog_weighting*0f;
					cat_weighting = cat_weighting*0f;
					lizard_weighting = lizard_weighting*0f;
					raccoon_weighting = raccoon_weighting*0f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*0f;
					cat_weighting = cat_weighting*0f;
				}		
				break;

			case 10: // Money
				if(Application.loadedLevel == 1){
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
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*1f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*2f;
					whore_weighting = whore_weighting*2f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*2f;
					homeless_weighting = homeless_weighting*4f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*3f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*0f;
					cat_weighting = cat_weighting*0f;
				}		
				break;

			case 11: // sex tape
				if(Application.loadedLevel == 1){
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
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0.2f;
					druggy_weighting = druggy_weighting*2f;
					whore_weighting = whore_weighting*1f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*2f;
					homeless_weighting = homeless_weighting*2f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*1f;
					dog_weighting = dog_weighting*0f;
					cat_weighting = cat_weighting*0f;
				}		
				break;

			case 12: // Lovecraft book
				if(Application.loadedLevel == 1){
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
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*3f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*1f;
					homeless_weighting = homeless_weighting*1f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*0f;
					cat_weighting = cat_weighting*0f;
				}		
				break;

			case 13: // Snake
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*1f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*1f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*1f;
					whore_weighting = whore_weighting*1f;
					priest_weighting = priest_weighting*1f;
					drunk_weighting = drunk_weighting*1f;
					homeless_weighting = homeless_weighting*1f;
					pharmacist_weighting = pharmacist_weighting*1f;
					banker_weighting = banker_weighting*1f;
					binman_weighting = binman_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 14: // Rabbit
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*1f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 15: // deer
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*0f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*1f;
					rabbit_weighting = rabbit_weighting*0f;
					deer_weighting = deer_weighting*0f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*0f;
					chicken_weighting = chicken_weighting*0f;
					owl_weighting = owl_weighting*0f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*0f;
					raccoon_weighting = raccoon_weighting*0f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 16: // skunk
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*1f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*0f;
					cat_weighting = cat_weighting*0f;
				}		
				break;

			case 17: // Hedgehog
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*1f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 18: // Chicken
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*1f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 19: // owl
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*1f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 20: // eagle
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*1f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 21: // pigeon
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*1f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 22: // dog
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*1f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 23: // cat
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*1f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 24: // lizard
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*1f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 25: // goth
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*3f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 26: // mayor
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*3f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 27: // druggy
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*3f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 28: // whore
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*3f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*1f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 29: // priest
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*3f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 30: // drunk
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*3f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 31: // homeless
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*3f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 32: // pharmacist
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*3f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*1f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 33: // banker
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*3f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*1f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 34: // binman
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*3f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*0f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;

			case 35: // raccoon
				if(Application.loadedLevel == 1){
					squirrel_weighting = squirrel_weighting*1f;
					beaver_weighting = beaver_weighting*1f;
					snake_weighting = snake_weighting*1f;
					spider_weighting = spider_weighting*1f;
					mouse_weighting = mouse_weighting*1f;
					bear_weighting = bear_weighting*3f;
					rabbit_weighting = rabbit_weighting*1f;
					deer_weighting = deer_weighting*1f;
					skunk_weighting = skunk_weighting*1f;
					hedgehog_weighting = hedgehog_weighting*1f;
					chicken_weighting = chicken_weighting*1f;
					owl_weighting = owl_weighting*1f;
					eagle_weighting = eagle_weighting*1f;
					pigeon_weighting = pigeon_weighting*1f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
					lizard_weighting = lizard_weighting*1f;
					raccoon_weighting = raccoon_weighting*1f;
				}	
				if(Application.loadedLevel == 3){
					goth_weighting = goth_weighting*0f;
					mayor_weighting = mayor_weighting*0f;
					druggy_weighting = druggy_weighting*0f;
					whore_weighting = whore_weighting*0f;
					priest_weighting = priest_weighting*0f;
					drunk_weighting = drunk_weighting*0f;
					homeless_weighting = homeless_weighting*2f;
					pharmacist_weighting = pharmacist_weighting*0f;
					banker_weighting = banker_weighting*0f;
					binman_weighting = binman_weighting*0f;
					dog_weighting = dog_weighting*1f;
					cat_weighting = cat_weighting*1f;
				}		
				break;
		}

		if(Application.loadedLevel == 1){
			float [] chanceIndex = new float [18];
			cumalativeChance = new float [chanceIndex.Length];
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

			rand = Random.Range(0, totalChance);
			Debug.Log("squirrel chance: "+squirrel_chance + " beaver chance: " + beaver_chance +  " snake chance: " + snake_chance + " spider chance: "+spider_chance +" total chance: "+totalChance+" rand: "+rand);
		}

		if(Application.loadedLevel == 3){
			float [] chanceIndex = new float [13];
			cumalativeChance = new float [chanceIndex.Length];
			//Process Distance Modifier = final chances
			// seperate these per town/woods
			float banker_chance = chanceIndex[0] = banker_weighting/(distanceToBanker/totalDist);
			float binman_chance = chanceIndex[1] = binman_weighting/(distanceToBinman/totalDist);
			float cat_chance = chanceIndex[2] = cat_weighting/(distanceToCat/totalDist);
			float dog_chance = chanceIndex[3] = dog_weighting/(distanceToDog/totalDist);
			float druggy_chance = chanceIndex[4] = druggy_weighting/(distanceToDruggy/totalDist);
			float drunk_chance = chanceIndex[5] = drunk_weighting/(distanceToDruggy/totalDist);
			float goth_chance = chanceIndex[6] = goth_weighting/(distanceToGoth/totalDist);
			float homeless_chance = chanceIndex[7] = homeless_weighting/(distanceToHomeless/totalDist);
			float mayor_chance = chanceIndex[8] = mayor_weighting/(distanceToMayor/totalDist);
			float pharmacist_chance = chanceIndex[9] = pharmacist_weighting/(distanceToPharmacist/totalDist);
			float pigeon_chance = chanceIndex[10] = pigeon_weighting/(distanceToPigeon/totalDist);
			float priest_chance = chanceIndex[11] = priest_weighting/(distanceToPriest/totalDist);
			float whore_chance = chanceIndex[12] = whore_weighting/(distanceToWhore/totalDist);
			

			

			float totalChance = banker_chance + binman_chance + cat_chance + dog_chance + druggy_chance + drunk_chance + 
			goth_chance + homeless_chance + mayor_chance + pharmacist_chance + pigeon_chance + priest_chance + whore_chance;

			Debug.Log(banker_chance + " " + binman_chance  + " "+ cat_chance + " " + dog_chance + " "+ druggy_chance + " " + drunk_chance + " " + 
			goth_chance  + " "+ homeless_chance + " " + mayor_chance + " " + pharmacist_chance + " " + pigeon_chance + " "+ priest_chance + " " + whore_chance);

			for(int i = 0; i<chanceIndex.Length; i++){
				if(i == 0) cumalativeChance[0] = chanceIndex[0];
				else{ 
					cumalativeChance[i] = chanceIndex[i] + cumalativeChance[i-1];
					//Debug.Log(chanceIndex[i] + " + " +cumalativeChance[i-1]);
				}
				//Debug.Log("total " + cumalativeChance[i]);
			}

			rand = Random.Range(0, totalChance);
			//Debug.Log("squirrel chance: "+squirrel_chance + " beaver chance: " + beaver_chance +  " snake chance: " + snake_chance + " spider chance: "+spider_chance +" total chance: "+totalChance+" rand: "+rand);
		}
		
		if(Application.loadedLevel == 1){

			if(rand < cumalativeChance[0]){
				Debug.Log("Rand:" + rand + " Caught Squirrel");
				itemObject = baitItem.squirrel_b;
				return "Squirrel";
			}
			else if(rand >= cumalativeChance[0] && rand < cumalativeChance[1]){
				Debug.Log("Rand:" + rand + " Caught Beaver");
				itemObject = baitItem.beaver_b;
				return "Beaver";
			}
			else if(rand >= cumalativeChance[1] && rand < cumalativeChance[2]){
				Debug.Log("Rand:" + rand + " Caught Snake");
				itemObject = baitItem.snake_b;
				return "Snake";
			}
			else if(rand >= cumalativeChance[2] && rand < cumalativeChance[3]){
				Debug.Log("Rand:" + rand + " Caught Spider");
				itemObject = baitItem.spider_b;
				return "Spider";
			}
			else if(rand >= cumalativeChance[3] && rand < cumalativeChance[4]){
				Debug.Log("Rand:" + rand + " Caught Mouse");
				itemObject = baitItem.mouse_b;
				return "Mouse";
			}
			else if(rand >= cumalativeChance[4] && rand < cumalativeChance[5]){
				Debug.Log("Rand:" + rand + " Caught Bear");
				itemObject = baitItem.bear_b;
				return "Bear";
			}
			else if(rand >= cumalativeChance[5] && rand < cumalativeChance[6]){
				Debug.Log("Rand:" + rand + " Caught Rabbit");
				itemObject = baitItem.rabbit_b;
				return "Rabbit";
			}
			else if(rand >= cumalativeChance[6] && rand < cumalativeChance[7]){
				Debug.Log("Rand:" + rand + " Caught Deer");
				itemObject = baitItem.deer_b;
				return "Deer";
			}
			else if(rand >= cumalativeChance[7] && rand < cumalativeChance[8]){
				Debug.Log("Rand:" + rand + " Caught Skunk");
				itemObject = baitItem.skunk_b;
				return "Skunk";
			}
			else if(rand >= cumalativeChance[8] && rand < cumalativeChance[9]){
				Debug.Log("Rand:" + rand + " Caught Hedgehog");
				itemObject = baitItem.hedgehog_b;
				return "Hedgehog";
			}
			else if(rand >= cumalativeChance[9] && rand < cumalativeChance[10]){
				Debug.Log("Rand:" + rand + " Caught Chicken");
				itemObject = baitItem.chicken_b;
				return "Chicken";
			}
			else if(rand >= cumalativeChance[10] && rand < cumalativeChance[11]){
				Debug.Log("Rand:" + rand + " Caught Owl");
				itemObject = baitItem.owl_b;
				return "Owl";
			}
			else if(rand >= cumalativeChance[11] && rand < cumalativeChance[12]){
				Debug.Log("Rand:" + rand + " Caught Eagle");
				itemObject = baitItem.eagle_b;
				return "Eagle";
			}
			else if(rand >= cumalativeChance[12] && rand < cumalativeChance[13]){
				Debug.Log("Rand:" + rand + " Caught Pigeon");
				itemObject = baitItem.pigeon_b;
				return "Pigeon";
			}
			else if(rand >= cumalativeChance[13] && rand < cumalativeChance[14]){
				Debug.Log("Rand:" + rand + " Caught Dog");
				itemObject = baitItem.dog_b;
				return "Dog";
			}
			else if(rand >= cumalativeChance[14] && rand < cumalativeChance[15]){
				Debug.Log("Rand:" + rand + " Caught Cat");
				itemObject = baitItem.cat_b;
				return "Cat";
			}
			else if(rand >= cumalativeChance[15] && rand < cumalativeChance[16]){
				Debug.Log("Rand:" + rand + " Caught Lizard");
				itemObject = baitItem.lizard_b;
				return "Lizard";
			}
			else if(rand >= cumalativeChance[16] && rand < cumalativeChance[17]){
				Debug.Log("Rand:" + rand + " Caught Raccoon");
				itemObject = baitItem.raccoon_b;
				return "Raccoon";
			}
		
			
			else
				return "ERROR";
		}

		if(Application.loadedLevel == 3){

			if(rand < cumalativeChance[0]){
				Debug.Log("Rand:" + rand + " Caught Banker");
				itemObject = baitItem.banker_b;
				PlayerPrefs.SetInt("CaughtBanker",1);
				return "Banker";
			}
			else if(rand >= cumalativeChance[0] && rand < cumalativeChance[1]){
				Debug.Log("Rand:" + rand + " Caught Binman");
				itemObject = baitItem.binman_b;
				PlayerPrefs.SetInt("CaughtBinman",1);
				return "Binman";
			}
			else if(rand >= cumalativeChance[1] && rand < cumalativeChance[2]){
				Debug.Log("Rand:" + rand + " Caught Cat");
				itemObject = baitItem.cat_b;
				PlayerPrefs.SetInt("CaughtCat",1);
				return "Cat";
			}
			else if(rand >= cumalativeChance[2] && rand < cumalativeChance[3]){
				Debug.Log("Rand:" + rand + " Caught Dog");
				itemObject = baitItem.dog_b;
				PlayerPrefs.SetInt("CaughtDog",1);
				return "Dog";
			}
			else if(rand >= cumalativeChance[3] && rand < cumalativeChance[4]){
				Debug.Log("Rand:" + rand + " Caught Druggy");
				itemObject = baitItem.druggy_b;
				PlayerPrefs.SetInt("CaughtDruggy",1);
				return "Druggy";
			}
			else if(rand >= cumalativeChance[4] && rand < cumalativeChance[5]){
				Debug.Log("Rand:" + rand + " Caught Drunk");
				itemObject = baitItem.drunk_b;
				PlayerPrefs.SetInt("CaughtDrunk",1);
				return "Drunk";
			}
			else if(rand >= cumalativeChance[5] && rand < cumalativeChance[6]){
				Debug.Log("Rand:" + rand + " Caught Goth");
				itemObject = baitItem.goth_b;
				PlayerPrefs.SetInt("CaughtGoth",1);
				return "Goth";
			}
			else if(rand >= cumalativeChance[6] && rand < cumalativeChance[7]){
				Debug.Log("Rand:" + rand + " Caught Homeless");
				itemObject = baitItem.homeless_b;
				PlayerPrefs.SetInt("CaughtHomeless",1);
				return "Homeless";
			}
			else if(rand >= cumalativeChance[7] && rand < cumalativeChance[8]){
				Debug.Log("Rand:" + rand + " Caught Mayor");
				itemObject = baitItem.mayor_b;
				PlayerPrefs.SetInt("CaughtMayor",1);
				return "Mayor";
			}
			else if(rand >= cumalativeChance[8] && rand < cumalativeChance[9]){
				Debug.Log("Rand:" + rand + " Caught Pharmacist");
				itemObject = baitItem.pharmacist_b;
				PlayerPrefs.SetInt("CaughtPharmacist",1);
				return "Pharmacist";
			}
			else if(rand >= cumalativeChance[9] && rand < cumalativeChance[10]){
				Debug.Log("Rand:" + rand + " Caught Pigeon");
				itemObject = baitItem.pigeon_b;
				PlayerPrefs.SetInt("CaughtPigeon",1);
				return "Pigeon";
			}
			else if(rand >= cumalativeChance[10] && rand < cumalativeChance[11]){
				Debug.Log("Rand:" + rand + " Caught Priest");
				itemObject = baitItem.priest_b;
				PlayerPrefs.SetInt("CaughtPriest",1);
				return "Priest";
			}
			else if(rand >= cumalativeChance[11] && rand < cumalativeChance[12]){
				Debug.Log("Rand:" + rand + " Caught Whore");
				itemObject = baitItem.whore_b;
				PlayerPrefs.SetInt("CaughtWhore",1);
				return "Whore";
			}
			
			else
				return "ERROR";
		}

		return "OUT ERROR";
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
			if(PlayerPrefs.GetInt ("Captured") == 0)
				PlayerPrefs.SetInt ("Captured", 1);
			if(PlayerPrefs.GetInt ("CapturedTown") == 0 && PlayerPrefs.GetInt ("LevelSelect") == 2)
				PlayerPrefs.SetInt("CapturedTown", 1);
			Destroy (gameObject);

			PlayerPrefs.SetInt ("Hunger", PlayerPrefs.GetInt ("Hunger") +180);
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
			if(PlayerPrefs.GetInt ("Captured") == 0)
				PlayerPrefs.SetInt ("Captured", 1);
			Destroy (gameObject);
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
		else if(capture == "Beaver")
			GUILayout.Box(beaver);
		else if(capture == "Spider")
			GUILayout.Box(spider);
		else if(capture == "Mouse")
			GUILayout.Box(mouse);
		else if(capture == "Bear")
			GUILayout.Box(bear);
		else if(capture == "Snake")
			GUILayout.Box(snake);
		else if(capture == "Rabbit")
			GUILayout.Box(rabbit);
		else if(capture == "Deer")
			GUILayout.Box(deer);
		else if(capture == "Skunk")
			GUILayout.Box(skunk);
		else if(capture == "Hedgehog")
			GUILayout.Box(hedgehog);
		else if(capture == "Chicken")
			GUILayout.Box(chicken);
		else if(capture == "Owl")
			GUILayout.Box(owl);
		else if(capture == "Eagle")
			GUILayout.Box(eagle);
		else if(capture == "Pigeon")
			GUILayout.Box(pigeon);
		else if(capture == "Dog")
			GUILayout.Box(dog);
		else if(capture == "Cat")
			GUILayout.Box(cat);
		else if(capture == "Lizard")
			GUILayout.Box(lizard);
		else if(capture == "Raccoon")
			GUILayout.Box(raccoon);

		else if(capture == "Banker")
			GUILayout.Box(banker);
		else if(capture == "Goth")
			GUILayout.Box(goth);
		else if(capture == "Mayor")
			GUILayout.Box(mayor);
		else if(capture == "Druggy")
			GUILayout.Box(druggy);
		else if(capture == "Whore")
			GUILayout.Box(whore);
		else if(capture == "Priest")
			GUILayout.Box(priest);
		else if(capture == "Drunk")
			GUILayout.Box(drunk);
		else if(capture == "Homeless")
			GUILayout.Box(homeless);
		else if(capture == "Pharmacist")
			GUILayout.Box(pharmacist);
		else if(capture == "Binman")
			GUILayout.Box(binman);
		

		GUILayout.EndHorizontal();
		GUILayout.Space(8);
		GUILayout.EndVertical();
        GUI.DragWindow();
    }
}
