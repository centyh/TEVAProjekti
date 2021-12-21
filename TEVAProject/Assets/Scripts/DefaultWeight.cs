using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultWeight : MonoBehaviour
{
    public GameObject defaultBox;
    
    public GameManager manager;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        manager = defaultBox.GetComponent<GameManager>();
    }


    void Update()
    {

    }
}
