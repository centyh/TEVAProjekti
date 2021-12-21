using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private OnTriggerEnter triggerScript;

    [SerializeField] private TextMeshProUGUI randomNumberText;
    [SerializeField] private GameObject[] boxes;
    [SerializeField] private GameObject boxArea;

    public int randomNumber;




    void Start()
    {
        triggerScript = GetComponent<OnTriggerEnter>();

        randomNumber = Random.Range(4, 4);
        randomNumberText.text = "" + randomNumber;
    }


    void Update()
    {

    }

    public void CheckingAnswer()
    {
        

        
    }



}
