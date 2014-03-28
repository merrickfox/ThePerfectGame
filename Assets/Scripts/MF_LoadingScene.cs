using UnityEngine;
using System.Collections;

public class MF_LoadingScene : MonoBehaviour {
	
	// Use this for initialization
	 IEnumerator Start() {
        AsyncOperation async = Application.LoadLevelAsync("TownScene");
        yield return async;
        Debug.Log("Loading complete");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
