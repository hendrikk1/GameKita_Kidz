using UnityEngine;
using System.Collections;

public class AnimTest : MonoBehaviour {
    public Animator anim;

	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponent<Animator>();
        //anim.StartPlayback();
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Stop() {
        anim.SetFloat("Speed", 0.1F);
    }
}
