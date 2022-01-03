using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultWeight2 : MonoBehaviour
{
    public GameObject defaultBox;

    public GameManager2 manager;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        manager = defaultBox.GetComponent<GameManager2>();
    }


    void Update()
    {

    }
}
