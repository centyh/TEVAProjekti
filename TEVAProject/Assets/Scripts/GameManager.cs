using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    

    [SerializeField] private TextMeshProUGUI randomNumberText;
    [SerializeField] private GameObject[] boxes;
    [SerializeField] private GameObject boxArea;

    private int randomNumber;
    //private int finalAnswer;
    public OnTriggerEnter finalanswer;

    


    void Start()
    {
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
                Debug.Log("Nice");
            }
            else if (finalanswer.finalAnswer >= randomNumber)
            {
                Debug.Log("Too much");
            }
            else if (finalanswer.finalAnswer <= randomNumber)
            {
                Debug.Log("Too little");
            }
            //Debug.Log("Kahtotaas");
        }               
    }



}
