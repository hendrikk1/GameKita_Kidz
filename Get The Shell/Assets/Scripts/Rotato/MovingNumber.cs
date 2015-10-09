using UnityEngine;
using System.Collections;

public class MovingNumber : MonoBehaviour {
    public float speed = 60;
    public int movement = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //movement = 0 = up | movement = 1 = down | movement = 2 = right | movement = 3 = left
        if(movement == 0){
            transform.Translate(0, speed / 16 * Time.deltaTime, 0);
        } else if(movement == 1){
            transform.Translate(0, -speed / 16 * Time.deltaTime, 0);
        } else if(movement == 2){
            transform.Translate(speed / 16 * Time.deltaTime, 0, 0);
        } else if(movement == 4){
            transform.Translate(-speed / 16 * Time.deltaTime, 0, 0);
        }

	}
}
