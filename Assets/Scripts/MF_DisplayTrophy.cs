using UnityEngine;
using System.Collections;

public class MF_DisplayTrophy : MonoBehaviour {

	public GameObject squirrelTrophy, beaverTrophy, bearTrophy, catTrophy, chickenTrophy, deerTrophy, dogTrophy, eagleTrophy, hedgehogTrophy
	, lizardTrophy, mouseTrophy, owlTrophy, pigeonTrophy, rabbitTrophy, raccoonTrophy, skunkTrophy, snakeTrophy, spiderTrophy;
	
	public GameObject bankerTrophy, druggyTrophy, drunkTrophy, gothTrophy, homelessTrophy, mayorTrophy, binmanTrophy, pharmacistTrophy, priestTrophy, whoreTrophy;

	// Use this for initialization
	void Start () {
		squirrelTrophy = GameObject.Find("Squirrel_Trophy");
		squirrelTrophy.GetComponent<MeshRenderer>().enabled = false;

		beaverTrophy = GameObject.Find("Beaver_Trophy");
		beaverTrophy.GetComponent<MeshRenderer>().enabled = false;

		bearTrophy = GameObject.Find("Bear_Trophy");
		bearTrophy.GetComponent<MeshRenderer>().enabled = false;

		catTrophy = GameObject.Find("Cat_Trophy");
		catTrophy.GetComponent<MeshRenderer>().enabled = false;

		chickenTrophy = GameObject.Find("Chicken_Trophy");
		chickenTrophy.GetComponent<MeshRenderer>().enabled = false;

		deerTrophy = GameObject.Find("Deer_Trophy");
		deerTrophy.GetComponent<MeshRenderer>().enabled = false;

		dogTrophy = GameObject.Find("Dog_Trophy");
		dogTrophy.GetComponent<MeshRenderer>().enabled = false;

		eagleTrophy = GameObject.Find("Eagle_Trophy");
		eagleTrophy.GetComponent<MeshRenderer>().enabled = false;

		hedgehogTrophy = GameObject.Find("Hedgehog_Trophy");
		hedgehogTrophy.GetComponent<MeshRenderer>().enabled = false;

		lizardTrophy = GameObject.Find("Lizard_Trophy");
		lizardTrophy.GetComponent<MeshRenderer>().enabled = false;

		mouseTrophy = GameObject.Find("Mouse_Trophy");
		mouseTrophy.GetComponent<MeshRenderer>().enabled = false;

		owlTrophy = GameObject.Find("Owl_Trophy");
		owlTrophy.GetComponent<MeshRenderer>().enabled = false;

		pigeonTrophy = GameObject.Find("Pigeon_Trophy");
		pigeonTrophy.GetComponent<MeshRenderer>().enabled = false;

		rabbitTrophy = GameObject.Find("Rabbit_Trophy");
		rabbitTrophy.GetComponent<MeshRenderer>().enabled = false;

		raccoonTrophy = GameObject.Find("Raccoon_Trophy");
		raccoonTrophy.GetComponent<MeshRenderer>().enabled = false;

		skunkTrophy = GameObject.Find("Skunk_Trophy");
		skunkTrophy.GetComponent<MeshRenderer>().enabled = false;

		snakeTrophy = GameObject.Find("Snake_Trophy");
		snakeTrophy.GetComponent<MeshRenderer>().enabled = false;

		spiderTrophy = GameObject.Find("Spider_Trophy");
		spiderTrophy.GetComponent<MeshRenderer>().enabled = false;
		//humans
		bankerTrophy = GameObject.Find("Banker_Trophy");
		bankerTrophy.GetComponent<MeshRenderer>().enabled = false;

		druggyTrophy = GameObject.Find("Druggy_Trophy");
		druggyTrophy.GetComponent<MeshRenderer>().enabled = false;

		drunkTrophy = GameObject.Find("Drunk_Trophy");
		drunkTrophy.GetComponent<MeshRenderer>().enabled = false;

		gothTrophy = GameObject.Find("Goth_Trophy");
		gothTrophy.GetComponent<MeshRenderer>().enabled = false;

		homelessTrophy = GameObject.Find("Homeless_Trophy");
		homelessTrophy.GetComponent<MeshRenderer>().enabled = false;

		mayorTrophy = GameObject.Find("Mayor_Trophy");
		mayorTrophy.GetComponent<MeshRenderer>().enabled = false;

		binmanTrophy = GameObject.Find("Binman_Trophy");
		binmanTrophy.GetComponent<MeshRenderer>().enabled = false;

		pharmacistTrophy = GameObject.Find("Pharmacist_Trophy");
		pharmacistTrophy.GetComponent<MeshRenderer>().enabled = false;

		priestTrophy = GameObject.Find("Priest_Trophy");
		priestTrophy.GetComponent<MeshRenderer>().enabled = false;

		whoreTrophy = GameObject.Find("Whore_Trophy");
		whoreTrophy.GetComponent<MeshRenderer>().enabled = false;

		if(PlayerPrefs.GetInt("CaughtSquirrel") == 1){
			squirrelTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtBeaver") == 1){
			beaverTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtBear") == 1){
			bearTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtCat") == 1){
			catTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtChicken") == 1){
			chickenTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtDeer") == 1){
			deerTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtDog") == 1){
			dogTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtEagle") == 1){
			eagleTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtHedgehog") == 1){
			hedgehogTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtLizard") == 1){
			lizardTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtMouse") == 1){
			mouseTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtOwl") == 1){
			owlTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtPigeon") == 1){
			pigeonTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtRabbit") == 1){
			rabbitTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtRaccoon") == 1){
			raccoonTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtSkunk") == 1){
			skunkTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtSnake") == 1){
			snakeTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtSpider") == 1){
			spiderTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtBanker") == 1){
			bankerTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtDruggy") == 1){
			druggyTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtDrunk") == 1){
			drunkTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtGoth") == 1){
			gothTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtHomeless") == 1){
			homelessTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtMayor") == 1){
			mayorTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtBinman") == 1){
			binmanTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtPharmacist") == 1){
			pharmacistTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtPriest") == 1){
			priestTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(PlayerPrefs.GetInt("CaughtWhore") == 1){
			whoreTrophy.GetComponent<MeshRenderer>().enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("l")){
			Debug.Log(PlayerPrefs.GetInt("CaughtWhore"));
		}
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

		if(trophy == "Bear"){
			PlayerPrefs.SetInt("CaughtBear",1);
			bearTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(trophy == "Cat"){
			PlayerPrefs.SetInt("CaughtCat",1);
			catTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(trophy == "Chicken"){
			PlayerPrefs.SetInt("CaughtChicken",1);
			chickenTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(trophy == "Deer"){
			PlayerPrefs.SetInt("CaughtDeer",1);
			deerTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(trophy == "Dog"){
			PlayerPrefs.SetInt("CaughtDog",1);
			dogTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(trophy == "Eagle"){
			PlayerPrefs.SetInt("CaughtEagle",1);
			eagleTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(trophy == "Hedgehog"){
			PlayerPrefs.SetInt("CaughtHedgehog",1);
			hedgehogTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(trophy == "Lizard"){
			PlayerPrefs.SetInt("CaughtLizard",1);
			lizardTrophy.GetComponent<MeshRenderer>().enabled = true;
		}

		if(trophy == "Mouse"){
			PlayerPrefs.SetInt("CaughtMouse",1);
			mouseTrophy.GetComponent<MeshRenderer>().enabled = true;
		}
		if(trophy == "Owl"){
			PlayerPrefs.SetInt("CaughtOwl",1);
			owlTrophy.GetComponent<MeshRenderer>().enabled = true;
		}
		if(trophy == "Pigeon"){
			PlayerPrefs.SetInt("CaughtPigeon",1);
			pigeonTrophy.GetComponent<MeshRenderer>().enabled = true;
		}
		if(trophy == "Rabbit"){
			PlayerPrefs.SetInt("CaughtRabbit",1);
			rabbitTrophy.GetComponent<MeshRenderer>().enabled = true;
		}
		if(trophy == "Raccoon"){
			PlayerPrefs.SetInt("CaughtRaccoon",1);
			raccoonTrophy.GetComponent<MeshRenderer>().enabled = true;
		}
		if(trophy == "Skunk"){
			PlayerPrefs.SetInt("CaughtSkunk",1);
			skunkTrophy.GetComponent<MeshRenderer>().enabled = true;
		}
		if(trophy == "Snake"){
			PlayerPrefs.SetInt("CaughtSnake",1);
			snakeTrophy.GetComponent<MeshRenderer>().enabled = true;
		}
		if(trophy == "Spider"){
			PlayerPrefs.SetInt("CaughtSpider",1);
			spiderTrophy.GetComponent<MeshRenderer>().enabled = true;
		}
	}
}
