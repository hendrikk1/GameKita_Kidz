using UnityEngine;
using System.Collections;
using System;

public class NumberScript : MonoBehaviour {
    public bool isNumber = true;
    public int numberIndex = 0;
    public TextMesh numberFromText;
    public int numberValue = 0;

    public bool numberTouched = false;
    public GameObject number1Place, number2Place, totalPlace;
    public Transform parent;

    public SpriteRenderer shell;

	// Use this for initialization
	void Start () {
        shell = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        numberValue = Convert.ToInt32(numberFromText.text);

        if(numberTouched)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            transform.parent = null;
            shell.enabled = false;

            if(numberIndex == 1)
            {
                transform.position = new Vector3(number1Place.transform.position.x, number1Place.transform.position.y, 0);                
            } 
            else if(numberIndex == 2)
            {
                transform.position = new Vector3(number2Place.transform.position.x, number2Place.transform.position.y, 0);
            } 
            else if(numberIndex == 3)
            {
                transform.position = new Vector3(totalPlace.transform.position.x, totalPlace.transform.position.y, 0);
            }
        }
	}
}
