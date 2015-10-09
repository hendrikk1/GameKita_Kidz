using UnityEngine;
using System.Collections;

public class BgmManager : MonoBehaviour {

    public AudioClip bgm;
	
    void Awake()
    {
        this.GetComponent<AudioSource>().clip = bgm;
        this.GetComponent<AudioSource>().Play();
    }
}