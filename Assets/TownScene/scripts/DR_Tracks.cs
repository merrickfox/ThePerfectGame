using UnityEngine;
using System.Collections;

public class DR_Tracks : MonoBehaviour 
{
	public GameObject sparkle;

	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (this.transform.parent.name == "tracksMouse") 
		{
			if (PlayerPrefs.GetInt ("Animal1") == 1)
					sparkle.SetActive (false);
		} 
		else if (this.transform.parent.name == "tracksSpider") 
		{
			if (PlayerPrefs.GetInt ("Animal2") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksSquirrel") 
		{
			if (PlayerPrefs.GetInt ("Animal3") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksSkunk") 
		{
			if (PlayerPrefs.GetInt ("Animal4") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksHedgehog") 
		{
			if (PlayerPrefs.GetInt ("Animal5") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksOwl") 
		{
			if (PlayerPrefs.GetInt ("Animal6") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksFish") 
		{
			if (PlayerPrefs.GetInt ("Animal7") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksBeaver") 
		{
			if (PlayerPrefs.GetInt ("Animal8") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksBear") 
		{
			if (PlayerPrefs.GetInt ("Animal9") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksRabbit") 
		{
			if (PlayerPrefs.GetInt ("Animal10") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksDeer") 
		{
			if (PlayerPrefs.GetInt ("Animal11") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksChicken") 
		{
			if (PlayerPrefs.GetInt ("Animal12") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksSnake") 
		{
			if (PlayerPrefs.GetInt ("Animal13") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksEagle") 
		{
			if (PlayerPrefs.GetInt ("Animal14") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksLizard") 
		{
			if (PlayerPrefs.GetInt ("Animal15") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksDog") 
		{
			if (PlayerPrefs.GetInt ("Animal16") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksCat") 
		{
			if (PlayerPrefs.GetInt ("Animal17") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksPidgeon") 
		{
			if (PlayerPrefs.GetInt ("Animal18") == 1)
				sparkle.SetActive (false);
		}
	}
	
	void OnTriggerStay(Collider other)
	{
		if (other.name == "Player") 
		{
			if(Input.GetKey(KeyCode.E))
			{
				if(this.transform.parent.name == "tracksMouse")
				PlayerPrefs.SetInt("Animal1", 1);
				else if(this.transform.parent.name == "tracksSpider")
					PlayerPrefs.SetInt("Animal2", 1);
				else if(this.transform.parent.name == "tracksSquirrel")
					PlayerPrefs.SetInt("Animal3", 1);
				else if(this.transform.parent.name == "tracksSkunk")
					PlayerPrefs.SetInt("Animal4", 1);
				else if(this.transform.parent.name == "tracksHedgehog")
					PlayerPrefs.SetInt("Animal5", 1);
				else if(this.transform.parent.name == "tracksOwl")
					PlayerPrefs.SetInt("Animal6", 1);
				else if(this.transform.parent.name == "tracksFish")
					PlayerPrefs.SetInt("Animal7", 1);
				else if(this.transform.parent.name == "tracksBeaver")
					PlayerPrefs.SetInt("Animal8", 1);
				else if(this.transform.parent.name == "tracksBear")
					PlayerPrefs.SetInt("Animal9", 1);
				else if(this.transform.parent.name == "tracksRabbit")
					PlayerPrefs.SetInt("Animal10", 1);
				else if(this.transform.parent.name == "tracksDeer")
					PlayerPrefs.SetInt("Animal11", 1);
				else if(this.transform.parent.name == "tracksChicken")
					PlayerPrefs.SetInt("Animal12", 1);
				else if(this.transform.parent.name == "tracksSnake")
					PlayerPrefs.SetInt("Animal13", 1);
				else if(this.transform.parent.name == "tracksEagle")
					PlayerPrefs.SetInt("Animal14", 1);
				else if(this.transform.parent.name == "tracksLizard")
					PlayerPrefs.SetInt("Animal15", 1);
				else if(this.transform.parent.name == "tracksDog")
					PlayerPrefs.SetInt("Animal16", 1);
				else if(this.transform.parent.name == "tracksCat")
					PlayerPrefs.SetInt("Animal17", 1);
				else if(this.transform.parent.name == "tracksPidgeon")
					PlayerPrefs.SetInt("Animal18", 1);
			}
		}
	}
}
