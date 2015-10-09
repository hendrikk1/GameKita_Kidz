using UnityEngine;
using System.Collections;

public class PlayScript : MonoBehaviour {
    public PauseScript pause;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown() {
        pause.gamePaused = false;
    }
}
