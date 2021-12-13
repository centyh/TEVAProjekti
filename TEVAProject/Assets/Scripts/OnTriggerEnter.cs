using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnter : MonoBehaviour
{
    private Value valueScript;

    public GameObject[] boxes;

    public Value number;

    public bool boxOnPlatform = false;

    private int amountBoxes;
    private int finalAnswer;
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

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            //Debug.Log("Vaaka tulo " + number.value);
            amountBoxes++;
            Debug.Log("Boxes on platform: " + amountBoxes);

            

        }
        

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Box")
        {  
            boxOnPlatform = true;
            //Debug.Log("Numero: " + number.value);

            if(collision.gameObject.name == "Square1")
            {
                //Debug.Log("Sininen box alueella");
                value1 = GameObject.Find("Square1").GetComponent<Value>().value;
                Debug.Log("Value: " + value1);
                
            }
            if(collision.gameObject.name == "Square2")
            {
                //Debug.Log("Vihreä box alueella");
                value2 = GameObject.Find("Square2").GetComponent<Value>().value;
                Debug.Log("Value: " + value2);
            }
            if(collision.gameObject.name == "Square3")
            {
                //Debug.Log("Punainen box alueella");
                value3 = GameObject.Find("Square3").GetComponent<Value>().value;
                Debug.Log("Value: " + value3);
            }
            if (collision.gameObject.name == "Square4")
            {
                //Debug.Log("Oranssi box alueella");
                value4 = GameObject.Find("Square4").GetComponent<Value>().value;
                Debug.Log("Value: " + value4);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            //Debug.Log("Pois Vaakalta " + number.value);
            boxOnPlatform = false;
            amountBoxes--;
            Debug.Log("Boxes on platform: " + amountBoxes);
        }
    }
}
