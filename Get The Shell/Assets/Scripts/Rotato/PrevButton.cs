using UnityEngine;
using System.Collections;

public class PrevButton : MonoBehaviour {
    public StageTransition stage;

	// Use this for initialization
	void Start () {
        stage = Object.FindObjectOfType<StageTransition>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnMouseDown() {
        stage.stage--;
    }
}
