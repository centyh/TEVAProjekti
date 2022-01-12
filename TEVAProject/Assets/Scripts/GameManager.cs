using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject defaultBox;

    public static GameManager Instance;

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI randomNumberText;
    [SerializeField] private GameObject[] boxes;
    [SerializeField] private GameObject boxArea;

    public int randomNumber;
    //private int finalAnswer;
    public OnTriggerEnter finalanswer;
    public ResetButton square1;
    public ResetButton square2;
    public ResetButton square3;
    public ResetButton square4;
    public Button checkButton;

    public GameObject correctText;
    public GameObject tooMuchText;
    public GameObject tooLittleText;

    private int currentScore;


    void Start()
    {
        GetComponent<ResetButton>();
        GetComponent<OnTriggerEnter>();
        defaultBox.GetComponent<Rigidbody2D>();


        randomNumber = Random.Range(1, 5);
        randomNumberText.text = "" + randomNumber;

        
    }


    void Update()
    {
        if (randomNumber == 1)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 1;
        }
        if (randomNumber == 2)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 2;
        }
        if (randomNumber == 3)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 3;
        }
        if (randomNumber == 4)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 4;
        }
        if (randomNumber == 5)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 5;
        }        

        scoreText.text = currentScore + "/10";
    }

    public void CheckTheAnswer()
    {        
        {
            finalanswer = FindObjectOfType<OnTriggerEnter>();
            Debug.Log("Final answer is " + finalanswer.finalAnswer);

            if (finalanswer.finalAnswer == randomNumber)
            {
                Debug.Log("Nice points++");
                randomNumber = Random.Range(1, 5);
                randomNumberText.text = "" + randomNumber;
                square1.GetComponent<ResetButton>().resetSquare1();
                square2.GetComponent<ResetButton>().resetSquare2();
                square3.GetComponent<ResetButton>().resetSquare3();
                square4.GetComponent<ResetButton>().resetSquare4();

                StartCoroutine(CorrectText());
                currentScore++;
                if(currentScore == 10)
                {
                    SceneManager.LoadScene(1);
                }

            }
            else if (finalanswer.finalAnswer >= randomNumber)
            {
                Debug.Log("Too much");
                StartCoroutine(TooMuchText());
            }
            else if (finalanswer.finalAnswer <= randomNumber)
            {
                Debug.Log("Too little");
                StartCoroutine(TooLittleText());
            }

        }               
    }


    IEnumerator CorrectText()
    {
        correctText.SetActive(true);
        checkButton.GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(3);
        checkButton.GetComponent<Button>().interactable = true;
        correctText.SetActive(false);
    }

    IEnumerator TooMuchText()
    {        
        tooMuchText.SetActive(true);        
        yield return new WaitForSeconds(3);        
        tooMuchText.SetActive(false);
    }

    IEnumerator TooLittleText()
    {
        tooLittleText.SetActive(true);
        yield return new WaitForSeconds(3);
        tooLittleText.SetActive(false);
    }

}
