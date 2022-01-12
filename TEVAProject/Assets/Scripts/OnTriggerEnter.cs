using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnter : MonoBehaviour
{
    private Value valueScript;
    private GameManager manager;

    public Value number;

    public bool boxOnPlatform1 = false;
    public bool boxOnPlatform2 = false;
    public bool boxOnPlatform3 = false;
    public bool boxOnPlatform4 = false;

    private int amountBoxes;
    public int finalAnswer;
    private int value1;
    private int value2;
    private int value3;
    private int value4;


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

    public void CheckAnswer()
    {

        
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
            finalAnswer += 1;
            Debug.Log("Final Answer is " + finalAnswer);
        }

        if (collision.gameObject.name == "Square2")
        {
            finalAnswer += 2;
            Debug.Log("Final Answer is " + finalAnswer);
        }

        if (collision.gameObject.name == "Square3")
        {
            finalAnswer += 3;
            Debug.Log("Final Answer is " + finalAnswer);
        }

        //if (collision.gameObject.name == "Square4")
        //{
        //    finalAnswer += 4;
        //    Debug.Log("Final Answer is " + finalAnswer);
        //}        
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
        //if (collision.gameObject.name == "Square4")
        //{
        //    //Debug.Log("Oranssi box alueella");
        //    value4 = GameObject.Find("Square4").GetComponent<Value>().value;
        //    boxOnPlatform4 = true;
        //    //Debug.Log("Value: " + value4);
        //}
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        boxOnPlatform1 = false;
        boxOnPlatform2 = false;
        boxOnPlatform3 = false;
        boxOnPlatform4 = false;

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
    }
}
