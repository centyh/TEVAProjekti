using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    private Vector3 maxAngle;
    private Vector3 minAngle;
    private Vector3 currentAngle;

    void Start()
    {
        
    }


    void Update()
    {
        //maxAngle = new Vector3(0, 0, 10f);
        //minAngle = new Vector3(0, 0, -8f);

        transform.rotation = Quaternion.Euler(0, 0, transform.rotation.z);
    }
}
