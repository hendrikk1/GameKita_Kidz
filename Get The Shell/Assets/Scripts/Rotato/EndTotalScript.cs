using UnityEngine;
using System.Collections;

public class EndTotalScript : MonoBehaviour {
    public int total = 0;
    //public EndNumberScript number1, number2;
    public bool arrived = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //total = number1.endNumberValue + number2.endNumberValue;
	}

    void OnCollisionStay(Collision collision)
    {
        try 
        {
            if (collision.collider.GetComponent<NumberScript>().isNumber)
            {
                arrived = true;
                total = collision.collider.GetComponent<NumberScript>().numberValue;
            }
        }
        catch { }        
    }
}
