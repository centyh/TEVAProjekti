using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingText : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void Start()
    {

    }

    void Update()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(target.position + offset);
        transform.position = pos;

    }
}
