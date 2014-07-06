using UnityEngine;
using System.Collections;

public class DR_Tracks : MonoBehaviour 
{
	public GameObject sparkle;
	
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

//----------------------------------- town ---------------------------------------
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
		else if (this.transform.parent.name == "tracksDruggy") 
		{
			if (PlayerPrefs.GetInt ("Animal19") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksWhore") 
		{
			if (PlayerPrefs.GetInt ("Animal20") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksDrunk") 
		{
			if (PlayerPrefs.GetInt ("Animal21") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksHomeless") 
		{
			if (PlayerPrefs.GetInt ("Animal22") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksBinman") 
		{
			if (PlayerPrefs.GetInt ("Animal23") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksPharmacist") 
		{
			if (PlayerPrefs.GetInt ("Animal24") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksGoth") 
		{
			if (PlayerPrefs.GetInt ("Animal25") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksPriest") 
		{
			if (PlayerPrefs.GetInt ("Animal26") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksBanker") 
		{
			if (PlayerPrefs.GetInt ("Animal27") == 1)
				sparkle.SetActive (false);
		}
		else if (this.transform.parent.name == "tracksMayor") 
		{
			if (PlayerPrefs.GetInt ("Animal28") == 1)
				sparkle.SetActive (false);
		}
	}
	
	void OnTriggerStay(Collider other)
	{
		if (other.name == "Player" || other.name == "First Person Controller") 
		{
			if(Input.GetKey(KeyCode.E))
			{
				if(this.transform.parent.name == "tracksMouse")
				{
					if(PlayerPrefs.GetInt ("Animal1") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal1", 1);
						PlayerPrefs.SetInt ("TrackerPage", 1);
					}	
				}
				else if(this.transform.parent.name == "tracksSpider")
				{
					if(PlayerPrefs.GetInt ("Animal2") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal2", 1);
						PlayerPrefs.SetInt ("TrackerPage", 1);
					}
				}
				else if(this.transform.parent.name == "tracksSquirrel")
				{
					if(PlayerPrefs.GetInt ("Animal3") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal3", 1);
						PlayerPrefs.SetInt ("TrackerPage", 1);
					}
				}
				else if(this.transform.parent.name == "tracksSkunk")
				{
					if(PlayerPrefs.GetInt ("Animal4") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal4", 1);
						PlayerPrefs.SetInt ("TrackerPage", 1);
					}
				}
				else if(this.transform.parent.name == "tracksHedgehog")
				{
					if(PlayerPrefs.GetInt ("Animal5") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal5", 1);
						PlayerPrefs.SetInt ("TrackerPage", 1);
					}
				}
				else if(this.transform.parent.name == "tracksOwl")
				{
					if(PlayerPrefs.GetInt ("Animal6") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal6", 1);
						PlayerPrefs.SetInt ("TrackerPage", 1);
					}
				}
				else if(this.transform.parent.name == "tracksFish")
				{
					if(PlayerPrefs.GetInt ("Animal7") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal7", 1);
						PlayerPrefs.SetInt ("TrackerPage", 1);
					}
				}
				else if(this.transform.parent.name == "tracksBeaver")
				{
					if(PlayerPrefs.GetInt ("Animal8") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal8", 1);
						PlayerPrefs.SetInt ("TrackerPage", 1);
					}
				}
				else if(this.transform.parent.name == "tracksBear")
				{
					if(PlayerPrefs.GetInt ("Animal9") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal9", 1);
						PlayerPrefs.SetInt ("TrackerPage", 1);
					}
				}
				else if(this.transform.parent.name == "tracksRabbit")
				{
					if(PlayerPrefs.GetInt ("Animal10") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal10", 1);
						PlayerPrefs.SetInt ("TrackerPage", 1);
					}
				}
				else if(this.transform.parent.name == "tracksDeer")
				{
					if(PlayerPrefs.GetInt ("Animal11") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal11", 1);
						PlayerPrefs.SetInt ("TrackerPage", 1);
					}
				}
				else if(this.transform.parent.name == "tracksChicken")
				{
					if(PlayerPrefs.GetInt ("Animal12") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal12", 1);
						PlayerPrefs.SetInt ("TrackerPage", 1);
					}
				}
				else if(this.transform.parent.name == "tracksSnake")
				{
					if(PlayerPrefs.GetInt ("Animal13") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal13", 1);
						PlayerPrefs.SetInt ("TrackerPage", 1);
					}
				}
				else if(this.transform.parent.name == "tracksEagle")
				{
					if(PlayerPrefs.GetInt ("Animal14") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal14", 1);
						PlayerPrefs.SetInt ("TrackerPage", 1);
					}
				}
				else if(this.transform.parent.name == "tracksLizard")
				{
					if(PlayerPrefs.GetInt ("Animal15") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal15", 1);
						PlayerPrefs.SetInt ("TrackerPage", 1);
					}
				}
		//----------------------------------- town ---------------------------------------
				else if(this.transform.parent.name == "tracksDog")
				{
					if(PlayerPrefs.GetInt ("Animal16") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal16", 1);
						PlayerPrefs.SetInt ("TrackerPage", 1);
					}
				}
				else if(this.transform.parent.name == "tracksCat")
				{
					if(PlayerPrefs.GetInt ("Animal17") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal17", 1);
						PlayerPrefs.SetInt ("TrackerPage", 1);
					}
				}
				else if(this.transform.parent.name == "tracksPidgeon")
				{
					if(PlayerPrefs.GetInt ("Animal18") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal18", 1);
						PlayerPrefs.SetInt ("TrackerPage", 1);
					}
				}
				else if(this.transform.parent.name == "tracksDruggy")
				{
					if(PlayerPrefs.GetInt ("Animal19") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal19", 1);
						PlayerPrefs.SetInt ("TrackerPage", 2);
					}
				}
				else if(this.transform.parent.name == "tracksWhore")
				{
					if(PlayerPrefs.GetInt ("Animal20") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal20", 1);
						PlayerPrefs.SetInt ("TrackerPage", 2);
					}
				}
				else if(this.transform.parent.name == "tracksDrunk")
				{
					if(PlayerPrefs.GetInt ("Animal21") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal21", 1);
						PlayerPrefs.SetInt ("TrackerPage", 2);
					}
				}
				else if(this.transform.parent.name == "tracksHomeless")
				{
					if(PlayerPrefs.GetInt ("Animal22") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal22", 1);
						PlayerPrefs.SetInt ("TrackerPage", 2);
					}
				}
				else if(this.transform.parent.name == "tracksBinman")
				{
					if(PlayerPrefs.GetInt ("Animal23") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal23", 1);
						PlayerPrefs.SetInt ("TrackerPage", 2);
					}
				}
				else if(this.transform.parent.name == "tracksPharmacist")
				{
					if(PlayerPrefs.GetInt ("Animal24") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal24", 1);
						PlayerPrefs.SetInt ("TrackerPage", 2);
					}
				}
				else if(this.transform.parent.name == "tracksGoth")
				{
					if(PlayerPrefs.GetInt ("Animal25") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal25", 1);
						PlayerPrefs.SetInt ("TrackerPage", 2);
					}
				}
				else if(this.transform.parent.name == "tracksPriest")
				{
					if(PlayerPrefs.GetInt ("Animal26") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal26", 1);
						PlayerPrefs.SetInt ("TrackerPage", 2);
					}
				}
				else if(this.transform.parent.name == "tracksBanker")
				{
					if(PlayerPrefs.GetInt ("Animal27") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal27", 1);
						PlayerPrefs.SetInt ("TrackerPage", 2);
					}
				}
				else if(this.transform.parent.name == "tracksMayor")
				{
					if(PlayerPrefs.GetInt ("Animal28") == 0)
					{
						PlayerPrefs.SetInt("Track", 1);
						PlayerPrefs.SetInt("Animal28", 1);
						PlayerPrefs.SetInt ("TrackerPage", 2);
					}
				}
			}
		}
	}
}
