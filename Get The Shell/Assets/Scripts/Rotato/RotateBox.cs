using UnityEngine;
using System.Collections;

public class RotateBox : MonoBehaviour {
    private Touch touch;
    public float rotateZ = 0;
    public bool mobileGame = false;
    public float rotateSpeed = 2;
    public float rotateZTemp = 0;
    
    public Animator anim;

    public bool isTouched = false;

	// Use this for initialization
	void Start () {
        //hilangi komen untuk build ke android
        //mobileGame = true;
        rotateZ = transform.rotation.z;
	}
	
	// Update is called once per frame
	void Update () {
        if(mobileGame){
            if (Input.touchCount == 1)
            {
                touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Stationary)
                {
                    isTouched = true;
                    if(isTouched){
                        if (touch.position.x <= Screen.width / 2)
                        {
                            rotateZ += rotateSpeed;
                            rotateZTemp = rotateZ;
                        }
                        else if (touch.position.x >= Screen.width / 2 && touch.position.x < Screen.width)
                        {
                            rotateZ -= rotateSpeed;
                            rotateZTemp = rotateZ;
                        }
                    }                    
                }                 
                else if(touch.phase == TouchPhase.Ended)
                {
                    isTouched = false;
                    rotateZ = rotateZTemp;
                }

            }
        } else if(!mobileGame){
            if(Input.GetKey(KeyCode.RightArrow)){
                rotateZ -= rotateSpeed;
            }

            if(Input.GetKey(KeyCode.LeftArrow)){
                rotateZ += rotateSpeed;
            }
        }
	    
        this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, rotateZ));
        anim.SetFloat("Speed", Mathf.Abs(rotateZ));
    }
}
