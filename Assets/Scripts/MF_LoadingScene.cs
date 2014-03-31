using UnityEngine;
using System.Collections;

public class MF_LoadingScene : MonoBehaviour {
	
	// Use this for initialization
	 IEnumerator Start() {
	 	if(PlayerPrefs.GetInt("Level") == 0){
	        AsyncOperation async = Application.LoadLevelAsync("TownScene");
	        yield return async;
	        Debug.Log("Loading complete");
    	}
    	else{
    		AsyncOperation async = Application.LoadLevelAsync("DanForestTut");
	        yield return async;
	        Debug.Log("Loading complete");
    	}
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
