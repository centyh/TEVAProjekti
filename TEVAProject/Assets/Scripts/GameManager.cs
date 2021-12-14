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
    private int finalAnswer;



    void Start()
    {
        GetComponent<OnTriggerEnter>();

        randomNumber = Random.Range(4, 4);
        randomNumberText.text = "" + randomNumber;
    }


    void Update()
    {

    }

    public void CheckTheAnswer()
    {
        Debug.Log("Kahtotaas");        
    }



}
