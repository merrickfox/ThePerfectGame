using UnityEngine;
using System.Collections;

public class MF_FloatScore : MonoBehaviour {
	
	public Color c;
	
	// Use this for initialization
	void Awake(){
		
	}
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if(gameObject)
		{
			//var smooth = 1.0f;
			//Debug.Log(transform.position.ToString());
			
	        //guiText.transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x,transform.position.y + 0.3f,transform.position.z), Time.deltaTime* smooth);
			guiText.fontSize += 5;
			c = guiText.material.color;
			c.a -= 0.015f;
			guiText.material.color = c;
			if(guiText.material.color.a <= 0)
			{
				Destroy (gameObject);
			}
		}
		
	}
}