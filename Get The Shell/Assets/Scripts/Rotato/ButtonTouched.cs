using UnityEngine;
using System.Collections;

public class ButtonTouched : MonoBehaviour {
    public bool buttonTouched = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown() {
        buttonTouched = true;
    }
}
