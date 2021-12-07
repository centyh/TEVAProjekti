using System.Collections;
using UnityEngine;

class DragAndDrop : MonoBehaviour
{
    private bool dragging = false;
    private float distance;


    void OnMouseDown()
    {
        distance = Vector2.Distance(transform.position, Camera.main.transform.position);
        dragging = true;
    }

    void OnMouseUp()
    {
        dragging = false;
    }

    void Update()
    {
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector2 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint;
        }
    }
}
