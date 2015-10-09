using UnityEngine;
using System.Collections;

public class LevelSelectScript : MonoBehaviour {
    public string levelSelect = "";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown() {
        Application.LoadLevel(levelSelect);
    }
}
