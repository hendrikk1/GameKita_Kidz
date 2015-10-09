using UnityEngine;
using System.Collections;

public class EndNumberScript : MonoBehaviour {
    public int endNumberValue = 0;
    public bool arrived = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionStay(Collision collision) 
    {
        try
        {
            if (collision.collider.GetComponent<NumberScript>().isNumber)
            {
                arrived = true;
                endNumberValue = collision.collider.GetComponent<NumberScript>().numberValue;
            }
        }
        catch { } 
    }
}
