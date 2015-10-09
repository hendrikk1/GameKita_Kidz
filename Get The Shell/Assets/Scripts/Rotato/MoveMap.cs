using UnityEngine;
using System.Collections;

public class MoveMap : MonoBehaviour {
    public Vector3 defaultPosition;
    public float[] widthRange, heightRange;

	// Update is called once per frame
	void Update () {
        
	    if(transform.position.x < widthRange[0])
        {
            transform.position = new Vector3(widthRange[0], transform.position.y, transform.position.z);
        }

        else if (transform.position.x > widthRange[1])
        {
            transform.position = new Vector3(widthRange[1], transform.position.y, transform.position.z);
        }

        else if (transform.position.y < heightRange[0])
        {
            transform.position = new Vector3(transform.position.x, heightRange[0], transform.position.z);
        }

        else if (transform.position.y > heightRange[1])
        {
            transform.position = new Vector3(transform.position.x, heightRange[1], transform.position.z);
        }
          
	}

    void OnMouseDrag()
    {
        float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
        transform.position = new Vector3(pos_move.x, pos_move.y, transform.position.z);
    }

    void OnMouseUp()
    {
        //transform.position = defaultPosition;
    }
}
