using UnityEngine;
using System.Collections;

public class ExplodeObstacle : MonoBehaviour {
    public GameObject expolde;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnCollisionEnter(Collision collision) {
        try {
            bool isPlayer = collision.collider.GetComponent<PlayerBehaviour>().player;
            if(isPlayer){
                Instantiate(expolde, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
        catch { }
    }
}
