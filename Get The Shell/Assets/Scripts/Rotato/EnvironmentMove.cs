using UnityEngine;
using System.Collections;

public class EnvironmentMove : MonoBehaviour {
    public float speed = 60;
    public bool opposite = false;
    public GameObject newBackground;

    public float zPos = 2;
    public float xPos = 0;
    public float yPos1 = -20.37F, yPos2 = -20.4F;

    public bool firstObject = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(!opposite){
            transform.Translate(0, speed / 16 * Time.deltaTime, 0);
        } else if(opposite){
            transform.Translate(0, -speed / 16 * Time.deltaTime, 0);
        }
        
        if(transform.position.y >= 10.2F){
            GenerateBackground();
            Destroy(gameObject);
        }
	}

    void GenerateBackground() {
        if(firstObject){
            Instantiate(newBackground, new Vector3(xPos, yPos1, zPos), newBackground.transform.rotation);
        } 
        else if(!firstObject){
            Instantiate(newBackground, new Vector3(xPos, yPos2, zPos), newBackground.transform.rotation);
        }           
    }
}
