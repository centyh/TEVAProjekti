using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInside : MonoBehaviour
{
    public Transform resetPoint;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        if(screenPos.x < 0)
        {
            transform.position = resetPoint.position;
        }
        else if(screenPos.x > Screen.width)
        {
            transform.position = resetPoint.position;
        }
        if(screenPos.y < 0)
        {
            transform.position = resetPoint.position;
        }
        else if(screenPos.y > Screen.height)
        {
            transform.position = resetPoint.position;
        }

    }
}
