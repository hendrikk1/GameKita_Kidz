using UnityEngine;
using System.Collections;

public class BackScript : MonoBehaviour {
    public string levelToLoad = "";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.Escape)){
            if(levelToLoad == "Room"){
                Application.LoadLevel("Room");
            } else if (levelToLoad == "exit"){
                Application.Quit();
            }
            
        }
	}
}
