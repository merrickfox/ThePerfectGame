using UnityEngine;
using System.Collections;

public class MF_TitleScreen : MonoBehaviour {

	public GUISkin MyGUISkin;
	float btnWidth, btnHeight;
	bool start;
	// Use this for initialization
	void Awake(){
		DontDestroyOnLoad(transform.gameObject);
	}
	void Start () {
		btnWidth = 200.0f;
		btnHeight = 400.0f;

	}
	
	// Update is called once per frame
	void Update () {
		
			
	}

	void OnGUI(){
		if(!start){
			GUI.skin = MyGUISkin;
			GUILayout.BeginArea(new Rect((Screen.width/2)-(btnWidth/2), Screen.height - 300, btnWidth, 200 ));
	        if(GUILayout.Button("New Game")){
	        	PlayerPrefs.DeleteAll();
	        	Application.LoadLevel("Merrick");
	        	start = true;
	        }
	        if(GUILayout.Button("Load Game")){
	        	Application.LoadLevel("Merrick");
	        	start = true;
	        }
	        if(GUILayout.Button("LeaderBoard")){
	        	Debug.Log("Leaderboard");
	        }
	        GUILayout.EndArea();
    	}
	}
}
