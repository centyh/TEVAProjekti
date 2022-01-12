using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultWeight3 : MonoBehaviour
{
    public GameObject defaultBox;

    public GameManager3 manager;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        manager = defaultBox.GetComponent<GameManager3>();
    }


    void Update()
    {

    }
}
