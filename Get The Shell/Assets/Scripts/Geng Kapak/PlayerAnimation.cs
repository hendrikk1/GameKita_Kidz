using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {
	public AudioClip[] soundEffect;
    public int animSelected = 0;
    public float timeToIdle = 0;
    public float timeLeft = 0;
    public GameObject mainCamera;
    public float rotateCamera = 0;
    public bool cameraRotated = false;

	// Use this for initialization
	void Start () {
        GetComponent<Animation>().Play("idle");
        rotateCamera = mainCamera.transform.rotation.y - 90;
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;

	    if(timeLeft == 0 || timeLeft < 0)
        {
            timeLeft = 0;
            GetComponent<Animation>().Play("idle");
        }
        else if (animSelected == 0 || animSelected == 2 || animSelected == 4 || animSelected == 6)
        {
            HappyBirthdayAnim();
            
        }
        else if (animSelected == 1 || animSelected == 5)
        {
            LaughingAnim();            
        }
        else if (animSelected == 3)
        {
            RoarAnim();            
        }
                
        if (GetComponent<AudioSource>().isPlaying)
        {
            return;
        }

        if(cameraRotated){
            rotateCamera++;
        }

        if (rotateCamera == 90 || rotateCamera > 90)
        {
            rotateCamera = 90;
        }

        mainCamera.transform.rotation = Quaternion.Euler(new Vector3(mainCamera.transform.rotation.x, rotateCamera, mainCamera.transform.rotation.z));
	}

    public void OnMouseDown() {
        cameraRotated = true;       
        
        animSelected = Random.Range(0, soundEffect.Length);
        if (animSelected == 0 || animSelected == 2 || animSelected == 4 || animSelected == 6)
        {
            timeLeft = 2.847F;            
        }
        else if (animSelected == 1 || animSelected == 5)
        {
            timeLeft = 1.2F;            
        }
        else if (animSelected == 3)
        {
            timeLeft = 3;   
        }
        GetComponent<AudioSource>().clip = soundEffect[animSelected];
        GetComponent<AudioSource>().Play();
    }

	public void RoarAnim(){
		GetComponent<Animation>().Play("roar");
	}

    public void LaughingAnim() {
        GetComponent<Animation>().Play("laughing");
    }

    public void HappyBirthdayAnim() {
        GetComponent<Animation>().Play("happy birthday");
    }
}
