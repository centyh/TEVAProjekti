using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPos : MonoBehaviour
{
    float lockPos;

    void Start()
    {
        
    }


    void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.z, lockPos, lockPos);
    }
}
