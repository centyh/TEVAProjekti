using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton2 : MonoBehaviour
{
    public Transform target;
    public void resetSquare1()
    {
        transform.position = target.position;
    }

    public void resetSquare2()
    {
        transform.position = target.position;
    }

    public void resetSquare3()
    {
        transform.position = target.position;
    }

    public void resetSquare4()
    {
        transform.position = target.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
