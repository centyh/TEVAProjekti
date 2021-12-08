using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnter : MonoBehaviour
{
    public Value number;

    public bool boxOnPlatform = false;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {          
        if (collision.gameObject.tag == "Alusta")
        {
            Debug.Log("Vaaka tulo " + number.value);
            boxOnPlatform = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Alusta")
        {
            Debug.Log("Pois Vaakalta " + number.value);
        }
    }
}
