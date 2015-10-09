using UnityEngine;
using System.Collections;

public class PlayUITransition : MonoBehaviour {
    public MainMenuScript playUI;

	// Use this for initialization
	void Start () {
        playUI = Object.FindObjectOfType<MainMenuScript>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void PlayUI() {
        playUI.PlayUIAnimation();
    }

    void ShowSprite() {
        playUI.ShowSprite();
    }
}
