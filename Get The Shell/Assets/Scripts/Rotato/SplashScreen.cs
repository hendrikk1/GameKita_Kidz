using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {
    public string scenes = "";
    public float timeToLoad = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timeToLoad -= Time.deltaTime;
        if(timeToLoad < 0){
            Application.LoadLevel(scenes);
        }
	}

    /*
    public void MoveScene() {
        Application.LoadLevel(scenes);
    }
     */ 
}
