using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformLogic : MonoBehaviour
{


    public int massOnScale;

    WeightLogic weightLogic;

    private void OnTriggerStay2D(Collider2D collision)
    {
        //massOnScale = collision.GetComponent<WeightLogic>().myWeight;
    }


    void Start()
    {
        
    }


    void Update()
    {
        //this.GetComponent<Rigidbody2D>().AddForce(Vector3.down * weightLogic.myWeight);
    }
}
