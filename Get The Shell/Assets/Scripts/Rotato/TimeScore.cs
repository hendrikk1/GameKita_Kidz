using UnityEngine;
using System.Collections;

public class TimeScore : MonoBehaviour {
    public float timeScore = 30;
    public float timeScoreTemp = 0;
    public TextMesh timeScoreText;
    public SpriteRenderer star1, star2, star3;
    public int starScore = 0;

    public bool timeIsRunning = false;

	// Use this for initialization
	void Start () {
        timeScoreTemp = timeScore;

        star3.enabled = true;
        star2.enabled = false;
        star1.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.touchCount == 1 ){
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                timeIsRunning = true;
            }
        }
        if(Input.anyKeyDown){
            timeIsRunning = true;
        }

        if(timeIsRunning){
            timeScore -= Time.deltaTime;
        }        

        if(timeScore == 0 || timeScore < 0){
            timeScore = 0;
        }

        timeScoreText.text = "" + (int)timeScore;

        if (timeScore == timeScoreTemp || timeScore < timeScoreTemp && timeScore > timeScoreTemp * 2 / 3)
        {
            star3.enabled = true;
            star2.enabled = false;
            star1.enabled = false;

            starScore = 3;
        }
        else if (timeScore == timeScoreTemp * 2 / 3 || timeScore < timeScoreTemp * 2 / 3 && timeScore > timeScoreTemp * 1 / 3)
        {
            star3.enabled = false;
            star2.enabled = true;
            star1.enabled = false;

            starScore = 2;
        }
        else if (timeScore == timeScoreTemp * 1 / 3 || timeScore < timeScoreTemp * 1 / 3)
        {
            star3.enabled = false;
            star2.enabled = false;
            star1.enabled = true;

            starScore = 1;
        }

        if(timeScore == timeScoreTemp && timeScore > 10)
        {
            timeScoreText.transform.position = new Vector3(-2.52F, timeScoreText.transform.position.y, timeScoreText.transform.position.z);
        } 
        else if(timeScore < 10)
        {
            timeScoreText.transform.position = new Vector3(-2.37F, timeScoreText.transform.position.y, timeScoreText.transform.position.z);
        }

	}
}
