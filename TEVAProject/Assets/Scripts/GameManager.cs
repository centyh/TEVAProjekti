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



}
