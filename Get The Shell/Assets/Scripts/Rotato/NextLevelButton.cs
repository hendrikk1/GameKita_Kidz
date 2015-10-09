using UnityEngine;
using System.Collections;

public class NextLevelButton : MonoBehaviour {
    public PlayerScript whatLevel;

	// Use this for initialization
	void Start () {
        whatLevel = Object.FindObjectOfType<PlayerScript>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnMouseDown() {
        Time.timeScale = 1;
        Application.LoadLevel(whatLevel.nextLevel);
    }
}
