using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameObject instance = null;

	void Awake () {
        //to make this object available throughout the game
        DontDestroyOnLoad(this.gameObject);

        //this is singleton gameobject
        if (instance == null)
        {
            instance = this.gameObject;
        }
        else
        {
            Destroy(this.gameObject);
        }
	}
}