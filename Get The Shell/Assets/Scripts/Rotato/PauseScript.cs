using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {
    public bool gamePaused = false;
    public Animator pauseMenu;
    
	// Use this for initialization
	void Start () {
        pauseMenu = gameObject.GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.Escape)){
            if(!gamePaused)
            {
                Pause();                
            } 
            else if(gamePaused)
            {
                Play();                
            }
        }

        if(gamePaused){
            Pause();
        } else if(!gamePaused){
            Play();
        }

        pauseMenu.SetBool("gamePaused", gamePaused);
	}

    public void Pause() {
        gamePaused = true;

    }

    public void Play() {
        Time.timeScale = 1;
        gamePaused = false;
    }

    public void ZeroTimeScale() {
        Time.timeScale = 0;
    }
}
