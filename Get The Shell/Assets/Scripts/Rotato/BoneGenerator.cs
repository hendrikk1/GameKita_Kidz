using UnityEngine;
using System.Collections;

public class BoneGenerator : MonoBehaviour {
    public float timeToGenerate = 0;
    public float maxTime = 4;
    public GameObject[] bone;
    public int randomBoneRange = 0;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timeToGenerate += Time.deltaTime;
        if(timeToGenerate == maxTime || timeToGenerate > maxTime){
            randomBoneRange = Random.Range(0, bone.Length);
            Instantiate(bone[randomBoneRange], new Vector3((float)Random.Range(-2, 2), bone[randomBoneRange].transform.position.y, bone[randomBoneRange].transform.position.z), transform.rotation);
            timeToGenerate = 0;
        }
	}
}
