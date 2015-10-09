using UnityEngine;
using System.Collections;

public class BoneScript : MonoBehaviour {
    public bool isBone = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnCollisionEnter2D(Collision2D collision) {
        try { 
            if(collision.collider.GetComponent<DeadZone>().deadZone){
                Destroy(gameObject);
            }
        }
        catch { }
    }
}
