using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerBehaviour : MonoBehaviour {
    public float speed = 60;
    public bool player = true;

    public float jumpSpeed = 500;

    public bool mobileGame = true;

    public float posX = 0;
    public Touch touch;

    public GameObject maincamera;
        
    public void Start(){
        posX = transform.position.x;
    }

    public void Update() {
        this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));

        maincamera.transform.position = new Vector3(this.transform.position.x, 0, -10);

        if(!mobileGame){
            if (Input.GetKey(KeyCode.RightArrow))
            {
                MoveRight();
            }
            else if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                ReleaseMove();
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                MoveLeft();
            }
            else if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                ReleaseMove();
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }

            this.transform.position = new Vector3(transform.position.x, transform.position.y, -1);
        } else if(mobileGame){
            posX += Input.acceleration.x / speed;
            this.transform.position = new Vector3(posX, transform.position.y, -1);

            if(Input.touchCount == 1){
                touch = Input.GetTouch(0);
                if(touch.phase == TouchPhase.Began){
                    Jump();
                }
            }
        }
        
    }

    /*Moving method*/
	private char moveLock='n'; // n=none, u=up, d= down, l=left, r=right
	
	public void MoveLeft(){
		if(moveLock=='n' || moveLock=='l'){
            GetComponent<Rigidbody>().useGravity = true;
            this.transform.Translate((-1 * (speed/8)) * Time.deltaTime, 0f, 0f);	
			moveLock='l';
		}
	}
	public void MoveRight(){
		if(moveLock=='n' || moveLock=='r'){
            GetComponent<Rigidbody>().useGravity = true;
            this.transform.Translate((speed/8) * Time.deltaTime, 0f, 0f);	
			moveLock='r';
		}
	}
    public void ReleaseMove() {        
        this.moveLock = 'n';
    }

    public void Jump() {
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpSpeed);
    }    

    public int Length { get; set; }
}
