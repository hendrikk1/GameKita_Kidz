using UnityEngine;
using System.Collections;

public class NumberGenerator : MonoBehaviour {
    public int number1 = 0, number2, total = 0;
    public int randomMin = 2, randomMax = 10;
    public TextMesh number1Text, number2Text, totalText;

	// Use this for initialization
	void Start () {
        number1 = Random.Range(randomMin, randomMax);
        number2 = Random.Range(randomMin, randomMax);
        total = number1 + number2;

        number1Text.text = "" + number1;
        number2Text.text = "" + number2;
        totalText.text = "" + total;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
