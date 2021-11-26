using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI randomNumberText;


    private int randomNumber;


    void Start()
    {
        randomNumber = Random.Range(3, 8);
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
