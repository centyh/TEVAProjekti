using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject defaultBox;
    public float currentMass;


    [SerializeField] private TextMeshProUGUI randomNumberText;
    [SerializeField] private GameObject[] boxes;
    [SerializeField] private GameObject boxArea;

    private int randomNumber;
    //private int finalAnswer;
    public OnTriggerEnter finalanswer;
    public ResetButton square1;
    public ResetButton square2;
    public ResetButton square3;
    public ResetButton square4;


    void Start()
    {
        GetComponent<ResetButton>();
        GetComponent<OnTriggerEnter>();


        randomNumber = Random.Range(4, 10);
        randomNumberText.text = "" + randomNumber;


    }


    void Update()
    {

    }

    public void CheckTheAnswer()
    {        
        {
            finalanswer = FindObjectOfType<OnTriggerEnter>();
            Debug.Log("Final answer is " + finalanswer.finalAnswer);

            if (finalanswer.finalAnswer == randomNumber)
            {
                Debug.Log("Nice points++");
                randomNumber = Random.Range(4, 10);
                randomNumberText.text = "" + randomNumber;
                square1.GetComponent<ResetButton>().resetSquare1();
                square2.GetComponent<ResetButton>().resetSquare2();
                square3.GetComponent<ResetButton>().resetSquare3();
                square4.GetComponent<ResetButton>().resetSquare4();


            }
            else if (finalanswer.finalAnswer >= randomNumber)
            {
                Debug.Log("Too much");
            }
            else if (finalanswer.finalAnswer <= randomNumber)
            {
                Debug.Log("Too little");
            }

        }               
    }



}
