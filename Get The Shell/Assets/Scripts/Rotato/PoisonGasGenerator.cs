using UnityEngine;
using System.Collections;

public class PoisonGasGenerator : MonoBehaviour {
    public float timeTogenerate = 0;
    public float maxTime = 7;
    public PoisonGasScript poisonGas;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        timeTogenerate += Time.deltaTime;
        if(timeTogenerate == maxTime || timeTogenerate > maxTime){

            //GameObject spawnGas = (GameObject)Instantiate(poisonGas, new Vector3(transform.position.x, transform.position.y, 0), poisonGas.transform.rotation);
            
            timeTogenerate = 0;
        }
	}
}
