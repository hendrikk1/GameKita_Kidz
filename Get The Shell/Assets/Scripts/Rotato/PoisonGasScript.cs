using UnityEngine;
using System.Collections;

public class PoisonGasScript : MonoBehaviour {
    public bool isPoisonGas = true;
    public BoxCollider2D boxCollider;
    public ParticleSystemRenderer particleRenderer;

    public float timeToActivated = 0;
    public float maxTime = 7;
    public bool poisonActivated = false;

    public float poisonTimeLeft = 3;
	// Use this for initialization
	void Start () {
        boxCollider = gameObject.GetComponent<BoxCollider2D>();

        boxCollider.enabled = false;
        particleRenderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if(!poisonActivated){
            timeToActivated += Time.deltaTime;
        } else if(poisonActivated){
            poisonTimeLeft -= Time.deltaTime;
        }
        
        if(timeToActivated == maxTime || timeToActivated > maxTime){
            PoisonActivated();
        }

        if(poisonTimeLeft == 0 || poisonTimeLeft < 0){
            PoisonUnactivated();
        }
	}

    public void PoisonActivated() {
        timeToActivated = 0;
        poisonActivated = true;
        boxCollider.enabled = true;
        particleRenderer.enabled = true;
    }

    public void PoisonUnactivated() {
        poisonTimeLeft = 3;
        poisonActivated = false;
        boxCollider.enabled = false;
        particleRenderer.enabled = false;
    }
}
