using UnityEngine;
using System.Collections;

public class MF_LoadingText : MonoBehaviour {
	bool okToRun;
	// Use this for initialization
	
	void Start () {
		okToRun = true;
	}
	
	// Update is called once per frame
	void Update () {
		Text();
	}

	void Text(){
		if(okToRun){
			okToRun = false;
			StartCoroutine(ChangeText());
		}
	}

	IEnumerator ChangeText(){
		for(int i = 0; i<7; i++){
			guiText.text += ".";
			yield return new WaitForSeconds(0.3f);
		}
		guiText.text = "Loading";
		okToRun = true;
	}

	
}
