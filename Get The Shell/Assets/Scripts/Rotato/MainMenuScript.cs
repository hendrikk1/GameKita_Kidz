using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {
    public ButtonTouched btnPlay, btnSetting, btnHelp, btnAbout, btnExtras;
    public Animator play, setting, help, about, extras;

    public SpriteRenderer btnPlaySprite, btnSettingSprite, btnHelpSprite, btnAboutSprite, btnExtrasSprite;

	// Use this for initialization
	void Start () {
        play.enabled = false;
        setting.enabled = false;
        help.enabled = false;
        about.enabled = false;
        extras.enabled = false;

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
        play.enabled = true;
        setting.enabled = true;
        help.enabled = true;
        about.enabled = true;
        extras.enabled = true;        
    }

    public void ShowSprite() {
        btnPlaySprite.enabled = true;
        btnSettingSprite.enabled = true;
        btnHelpSprite.enabled = true;
        btnAboutSprite.enabled = true;
        btnExtrasSprite.enabled = true;
    }   
}
