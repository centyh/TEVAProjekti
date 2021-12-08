using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnter : MonoBehaviour
{
    public Value number;

    public bool boxOnPlatform = false;

    private int amountBoxes;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Alusta")
        {
            Debug.Log("Vaaka tulo " + number.value);
            amountBoxes++;
            Debug.Log("Boxes on platform: " + amountBoxes);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Alusta")
        {  
            boxOnPlatform = true;
            //Debug.Log("Numero: " + number.value);
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Alusta")
        {
            Debug.Log("Pois Vaakalta " + number.value);
            boxOnPlatform = false;
            amountBoxes--;
            Debug.Log("Boxes on platform: " + amountBoxes);
        }
    }
}
