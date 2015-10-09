using UnityEngine;
using System.Collections;

public class SfxManager : MonoBehaviour {

    public void PlaySfx(AudioClip Sfx)
    {
        this.gameObject.GetComponent<AudioSource>().clip = Sfx;
        this.gameObject.GetComponent<AudioSource>().Play();
    }
    
    public void DisableSfx()
    {
        this.gameObject.GetComponent<AudioSource>().volume = 0;
    }

    public void EnableSfx()
    {
        this.gameObject.GetComponent<AudioSource>().volume = 1;
    }
}