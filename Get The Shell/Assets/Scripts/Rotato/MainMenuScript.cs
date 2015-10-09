using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {
    public ButtonTouched btnPlay, btnSetting, btnHelp, btnAbout, btnExtras;

    public SpriteRenderer btnPlaySprite, btnSettingSprite, btnHelpSprite, btnAboutSprite, btnExtrasSprite;

	// Use this for initialization
	void Start () {
        btnPlaySprite.enabled = false;
        btnSettingSprite.enabled = false;
        btnHelpSprite.enabled = false;
        btnAboutSprite.enabled = false;
        btnExtrasSprite.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	    if(btnPlay.buttonTouched){
            Application.LoadLevel("Stage");
        }

        if(btnSetting.buttonTouched){
        
        }

        if(btnHelp.buttonTouched){
        
        }
        
        if(btnAbout.buttonTouched){
        
        }

        if(btnExtras.buttonTouched){
        
        }

        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
	}

    public void PlayUIAnimation() {
    }

    public void ShowSprite() {
        btnPlaySprite.enabled = true;
        btnSettingSprite.enabled = true;
        btnHelpSprite.enabled = true;
        btnAboutSprite.enabled = true;
        btnExtrasSprite.enabled = true;
    }   
}
