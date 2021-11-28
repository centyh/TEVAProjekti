using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {        
        if (collision.gameObject.tag == "vaaka")
        {
            Debug.Log("Vaaka tulo");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "vaaka")
        {
            Debug.Log("Pois Vaakalta");
        }
    }
}
