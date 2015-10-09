using UnityEngine;
using System.Collections;

public class MovingStone : MonoBehaviour {
    public float speed = 60;
    public GameObject[] rocks;
    public int randomRangeRock = 0;
    public bool isRock = true;
    public int movement = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //movement = 0 = up || movement = 1 = down || movement = 2 = right || movement = 3 = left
        if(movement == 0){
            transform.Translate(0, speed / 16 * Time.deltaTime, 0);

            if (transform.position.y >= 3.5F)
            {
                randomRangeRock = Random.Range(0, rocks.Length);
                Instantiate(rocks[randomRangeRock], rocks[randomRangeRock].transform.position, rocks[randomRangeRock].transform.rotation);
                Destroy(gameObject);
            }
        } else if(movement == 1){
            transform.Translate(0, -speed / 16 * Time.deltaTime, 0);

            if (transform.position.y <= -3.5F)
            {
                randomRangeRock = Random.Range(0, rocks.Length);
                Instantiate(rocks[randomRangeRock], rocks[randomRangeRock].transform.position, rocks[randomRangeRock].transform.rotation);
                Destroy(gameObject);
            }
        } else if(movement == 2){
            transform.Translate(speed / 16 * Time.deltaTime, 0, 0);

            if (transform.position.y >= 3.5F)
            {
                randomRangeRock = Random.Range(0, rocks.Length);
                Instantiate(rocks[randomRangeRock], rocks[randomRangeRock].transform.position, rocks[randomRangeRock].transform.rotation);
                Destroy(gameObject);
            }
        } else if(movement == 3){
            transform.Translate(-speed / 16 * Time.deltaTime, 0, 0);

            if (transform.position.y <= -3.5F)
            {
                randomRangeRock = Random.Range(0, rocks.Length);
                Instantiate(rocks[randomRangeRock], rocks[randomRangeRock].transform.position, rocks[randomRangeRock].transform.rotation);
                Destroy(gameObject);
            }
        }     
        
	}

    void OnCollisionEnter2D(Collision2D collision) {
        try { 
            if(collision.collider.GetComponent<DestroyZone>().isDestroyZone){
                randomRangeRock = Random.Range(0, rocks.Length);
                Instantiate(rocks[randomRangeRock], rocks[randomRangeRock].transform.position, rocks[randomRangeRock].transform.rotation);
                Destroy(gameObject);
            }
        }
        catch { }
    }
}
