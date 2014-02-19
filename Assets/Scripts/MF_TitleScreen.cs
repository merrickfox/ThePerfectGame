using UnityEngine;
using System.Collections;

public class MF_TitleScreen : MonoBehaviour {

	public GUISkin MyGUISkin;
	float btnWidth, btnHeight;
	bool start;
	// Use this for initialization
	void Start () {
		btnWidth = 200.0f;
		btnHeight = 400.0f;

	}
	
	// Update is called once per frame
	void Update () {
		if(start)
			Application.LoadLevel("Merrick");
	}

	void OnGUI(){
		GUI.skin = MyGUISkin;
		GUILayout.BeginArea(new Rect((Screen.width/2)-(btnWidth/2), Screen.height - 300, btnWidth, 200 ));
        if(GUILayout.Button("New Game")){
        	start = true;
        }
        GUILayout.Button("Load Game");
        GUILayout.EndArea();
	}
}
