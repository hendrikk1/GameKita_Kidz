using UnityEngine;
using System.Collections;

public class PlayerBonusStage1 : MonoBehaviour {
    public float speed = 60;

    public bool mobileGame = false;
    public Touch touch;

    public Animator anim;
	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponent<Animator>();        
	}
	
	// Update is called once per frame
	void Update () {
        if(mobileGame){
            if (Input.touchCount == 1)
            {
                touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Stationary)
                {
                    if (touch.position.x <= Screen.width / 2)
                    {
                        transform.Translate(-speed / 15 * Time.deltaTime, 0, 0);
                    }
                    else if (touch.position.x >= Screen.width / 2 && touch.position.x < Screen.width)
                    {
                        transform.Translate(speed / 15 * Time.deltaTime, 0, 0);
                    }
                }
            }
        }
        else if(!mobileGame){
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(speed / 15 * Time.deltaTime, 0, 0);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-speed / 15 * Time.deltaTime, 0, 0);
            }
        }
        anim.SetFloat("Speed", Mathf.Abs(transform.position.x));
	}
}
