using UnityEngine;
using System.Collections;

public class ScoringScript : MonoBehaviour {
    public NumberScript number1, number2, total;
    public int number1Value = 0, number2Value = 0, totalValue = 0;
    public PlayerScript winOrLose;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(number1.numberTouched)
        {
            if(number1.numberIndex == 1)
            {
                number1Value = number1.numberValue;
            } 
            else if(number1.numberIndex == 2)
            {
                number2Value = number1.numberValue;
            } 
            else if(number1.numberIndex == 3)
            {
                totalValue = number1.numberValue;
            }
        }

        if(number2.numberTouched){
            if (number2.numberIndex == 1)
            {
                number1Value = number2.numberValue;
            }
            else if (number2.numberIndex == 2)
            {
                number2Value = number2.numberValue;
            }
            else if (number2.numberIndex == 3)
            {
                totalValue = number2.numberValue;
            }
        }

        if(total.numberTouched){
            if (total.numberIndex == 1)
            {
                number1Value = total.numberValue;
            }
            else if (total.numberIndex == 2)
            {
                number2Value = total.numberValue;
            }
            else if (total.numberIndex == 3)
            {
                totalValue = total.numberValue;
            }
        }

        if(totalValue != 0 && number1Value != 0 && number2Value != 0){
            if (totalValue == number1Value + number2Value)
            {
                winOrLose.win = true;
            }
            else if (totalValue != number1Value + number2Value)
            {
                winOrLose.gameOver = true;
            }
        }        
	}
}
