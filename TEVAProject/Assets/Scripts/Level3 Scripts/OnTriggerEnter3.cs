using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnter3 : MonoBehaviour
{
    private Value valueScript;
    private GameManager3 manager;

    public Value number;

    public bool boxOnPlatform1 = false;
    public bool boxOnPlatform2 = false;
    public bool boxOnPlatform3 = false;
    public bool boxOnPlatform4 = false;
    public bool boxOnPlatform5 = false;
    public bool boxOnPlatform6 = false;
    public bool boxOnPlatform7 = false;

    private int amountBoxes;
    public int finalAnswer;
    private int value1;
    private int value2;
    private int value3;
    private int value4;
    private int value5;
    private int value6;
    private int value7;


    void Start()
    {
        //finalAnswer = 4;

    }

    void Update()
    {
        //Debug.Log("amountBoxes " + amountBoxes + " finalanswer " + finalAnswer);

        if (amountBoxes == 0)
        {
            finalAnswer = 0;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Box")
        {
            //Debug.Log("Vaaka tulo " + number.value);
            amountBoxes++;
            Debug.Log("Boxes on platform: " + amountBoxes);
        }

        if (collision.gameObject.name == "Square1")
        {
            finalAnswer += 3;
            Debug.Log("Final Answer is " + finalAnswer);
        }

        if (collision.gameObject.name == "Square2")
        {
            finalAnswer += 6;
            Debug.Log("Final Answer is " + finalAnswer);
        }

        if (collision.gameObject.name == "Square3")
        {
            finalAnswer += 7;
            Debug.Log("Final Answer is " + finalAnswer);
        }

        if (collision.gameObject.name == "Square4")
        {
            finalAnswer += 8;
            Debug.Log("Final Answer is " + finalAnswer);
        }

        if (collision.gameObject.name == "Square5")
        {
            finalAnswer += 9;
            Debug.Log("Final Answer is " + finalAnswer);
        }

        if (collision.gameObject.name == "Square6")
        {
            finalAnswer += 10;
            Debug.Log("Final Answer is " + finalAnswer);
        }

        if (collision.gameObject.name == "Square7")
        {
            finalAnswer += 15;
            Debug.Log("Final Answer is " + finalAnswer);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Square1")
        {
            //Debug.Log("Sininen box alueella");
            value1 = GameObject.Find("Square1").GetComponent<Value>().value;
            boxOnPlatform1 = true;
            //Debug.Log("Value: " + value1);
        }
        if (collision.gameObject.name == "Square2")
        {
            //Debug.Log("Vihreä box alueella");
            value2 = GameObject.Find("Square2").GetComponent<Value>().value;
            boxOnPlatform2 = true;
            //Debug.Log("Value: " + value2);
        }
        if (collision.gameObject.name == "Square3")
        {
            //Debug.Log("Punainen box alueella");
            value3 = GameObject.Find("Square3").GetComponent<Value>().value;
            boxOnPlatform3 = true;
            //Debug.Log("Value: " + value3);
        }
        if (collision.gameObject.name == "Square4")
        {
            //Debug.Log("Oranssi box alueella");
            value4 = GameObject.Find("Square4").GetComponent<Value>().value;
            boxOnPlatform4 = true;
            //Debug.Log("Value: " + value4);
        }
        if (collision.gameObject.name == "Square5")
        {
            //Debug.Log("Oranssi box alueella");
            value5 = GameObject.Find("Square5").GetComponent<Value>().value;
            boxOnPlatform5 = true;
            //Debug.Log("Value: " + value4);
        }
        if (collision.gameObject.name == "Square6")
        {
            //Debug.Log("Oranssi box alueella");
            value6 = GameObject.Find("Square6").GetComponent<Value>().value;
            boxOnPlatform6 = true;
            //Debug.Log("Value: " + value4);
        }
        if (collision.gameObject.name == "Square7")
        {
            //Debug.Log("Oranssi box alueella");
            value7 = GameObject.Find("Square7").GetComponent<Value>().value;
            boxOnPlatform7 = true;
            //Debug.Log("Value: " + value4);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        boxOnPlatform1 = false;
        boxOnPlatform2 = false;
        boxOnPlatform3 = false;
        boxOnPlatform4 = false;
        boxOnPlatform5 = false;
        boxOnPlatform6 = false;
        boxOnPlatform7 = false;

        if (collision.gameObject.tag == "Box")
        {
            //Debug.Log("Pois Vaakalta " + number.value);            
            amountBoxes--;
            Debug.Log("Boxes on platform: " + amountBoxes);

        }

        if (collision.gameObject.name == "Square1" && boxOnPlatform1 == false)
        {
            finalAnswer -= value1;
            Debug.Log("Minus the Final Answer? " + finalAnswer);
        }

        if (collision.gameObject.name == "Square2" && boxOnPlatform2 == false)
        {
            finalAnswer -= value2;
            Debug.Log("Minus the Final Answer? " + finalAnswer);
        }

        if (collision.gameObject.name == "Square3" && boxOnPlatform3 == false)
        {
            finalAnswer -= value3;
            Debug.Log("Minus the Final Answer? " + finalAnswer);
        }

        if (collision.gameObject.name == "Square4" && boxOnPlatform4 == false)
        {
            finalAnswer -= value4;
            Debug.Log("Minus the Final Answer? " + finalAnswer);
        }

        if (collision.gameObject.name == "Square5" && boxOnPlatform5 == false)
        {
            finalAnswer -= value5;
            Debug.Log("Minus the Final Answer? " + finalAnswer);
        }

        if (collision.gameObject.name == "Square6" && boxOnPlatform6 == false)
        {
            finalAnswer -= value6;
            Debug.Log("Minus the Final Answer? " + finalAnswer);
        }

        if (collision.gameObject.name == "Square7" && boxOnPlatform7 == false)
        {
            finalAnswer -= value7;
            Debug.Log("Minus the Final Answer? " + finalAnswer);
        }
    }
}