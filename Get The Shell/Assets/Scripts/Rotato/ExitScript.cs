using UnityEngine;
using System.Collections;

public class ExitScript : MonoBehaviour {
    public string levelSelect = "Stage";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.Escape)){
            Application.LoadLevel(levelSelect);
        }
	}
}
