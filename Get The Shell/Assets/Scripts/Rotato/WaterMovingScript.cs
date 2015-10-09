using UnityEngine;
using System.Collections;

public class WaterMovingScript : MonoBehaviour {
    public float speed = 60;
    public GameObject newWater;
    public bool left = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(left){
            transform.Translate(-speed / 16*Time.deltaTime, 0, 0);
            if (transform.position.x < -18.84F)
            {
                Instantiate(newWater, new Vector3(19, newWater.transform.position.y, newWater.transform.position.z), transform.rotation);
                Destroy(gameObject);
            }
        } else if(!left){
            transform.Translate(speed / 16 * Time.deltaTime, 0, 0);
            if (transform.position.x > 19)
            {
                Instantiate(newWater, new Vector3(-18.84F, newWater.transform.position.y, newWater.transform.position.z), transform.rotation);
                Destroy(gameObject);
            }
        }

	}
}
