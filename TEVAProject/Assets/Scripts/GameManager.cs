using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    OnTriggerEnter triggerScript;
    DragAndDrop dragScript;

    [SerializeField] private TextMeshProUGUI randomNumberText;
    [SerializeField] private GameObject boxArea;
    [SerializeField] private GameObject[] boxes;

    private int randomNumber;
    private int finalAnswer;

    private bool boxInArea = false;

    private Value number;


    void Start()
    {
        GetComponent<OnTriggerEnter>();

        randomNumber = Random.Range(4, 8);
        randomNumberText.text = "" + randomNumber;

        randomNumber = finalAnswer;
    }


    void Update()
    {
       // CheckingArea();
    }

    public void CheckTheAnswer()
    {
        Debug.Log("Kahtotaas");
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("vaaka"))
        {
            boxInArea = true;
            Vector2 boxPosition = GameObject.Find("Box").transform.position;
            Vector2 area;
            area = new Vector2(boxArea.transform.position.x, boxArea.transform.position.y);

            Debug.Log("Box value: " + triggerScript.number);
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        boxInArea = false;
    }
}
