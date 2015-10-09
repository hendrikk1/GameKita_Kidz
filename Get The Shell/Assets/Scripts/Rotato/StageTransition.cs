using UnityEngine;
using System.Collections;

public class StageTransition : MonoBehaviour {
    public int stage = 1;
    public Animator cameraAnim;

	// Use this for initialization
	void Start () {
        cameraAnim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(stage == 1)
        {
            cameraAnim.SetInteger("Stage", 1);
        } 
        else if (stage == 2)
        {
            cameraAnim.SetInteger("Stage", 2);
        } 
        else if (stage == 3)
        {
            cameraAnim.SetInteger("Stage", 3);
        }

        if(stage > 3 || stage < 1){
            stage = 1;
        }
	}
}
