using UnityEngine;
using System.Collections;

public class TurnSound : MonoBehaviour {
    public int i = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(i>1){
            i = 0;
        }

        if (i == 1)
        {
            GetComponent<AudioSource>().mute = true;
        }
        else {
            GetComponent<AudioSource>().mute = false;
        }   
	}

    public void OnMouseDown() {
        i++;        
        Debug.Log("clicked");        
    }
}
