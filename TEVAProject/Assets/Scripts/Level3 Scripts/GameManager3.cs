using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager3 : MonoBehaviour
{
    public GameObject defaultBox;

    public static GameManager Instance;

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI randomNumberText;
    [SerializeField] private GameObject[] boxes;
    [SerializeField] private GameObject boxArea;

    public int randomNumber;
    //private int finalAnswer;
    public OnTriggerEnter3 finalanswer;
    public ResetButton square1;
    public ResetButton square2;
    public ResetButton square3;
    public ResetButton square4;
    public ResetButton square5;
    public ResetButton square6;
    public ResetButton square7;
    public Button checkButton;

    public GameObject correctText;
    public GameObject tooMuchText;
    public GameObject tooLittleText;
    public GameObject correctMarker;
    public GameObject goodJob;

    public int currentScore;


    void Start()
    {
        GetComponent<ResetButton>();
        GetComponent<OnTriggerEnter3>();
        defaultBox.GetComponent<Rigidbody2D>();


        randomNumber = Random.Range(16, 41);
        randomNumberText.text = "" + randomNumber;


    }


    void Update()
    {
        if (randomNumber == 16)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 1.6f;
        }
        if (randomNumber == 17)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 1.7f;
        }
        if (randomNumber == 18)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 1.8f;
        }
        if (randomNumber == 19)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 1.9f;
        }
        if (randomNumber == 20)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 2.0f;
        }
        if (randomNumber == 21)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 2.1f;
        }
        if (randomNumber == 22)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 2.2f;
        }
        if (randomNumber == 23)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 2.3f;
        }
        if (randomNumber == 24)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 2.4f;
        }
        if (randomNumber == 25)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 2.5f;
        }
        if (randomNumber == 26)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 2.6f;
        }
        if (randomNumber == 27)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 2.7f;
        }
        if (randomNumber == 28)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 2.8f;
        }
        if (randomNumber == 29)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 2.9f;
        }
        if (randomNumber == 30)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 3.0f;
        }
        if (randomNumber == 31)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 3.1f;
        }
        if (randomNumber == 32)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 3.2f;
        }
        if (randomNumber == 33)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 3.3f;
        }
        if (randomNumber == 34)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 3.4f;
        }
        if (randomNumber == 35)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 3.5f;
        }
        if (randomNumber == 36)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 3.6f;
        }
        if (randomNumber == 37)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 3.7f;
        }
        if (randomNumber == 38)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 3.8f;
        }
        if (randomNumber == 39)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 3.9f;
        }
        if (randomNumber == 40)
        {
            defaultBox.GetComponent<Rigidbody2D>().mass = 4.0f;
        }


        scoreText.text = currentScore + "/10";
    }

    public void CheckTheAnswer()
    {
        {
            finalanswer = FindObjectOfType<OnTriggerEnter3>();
            //Debug.Log("Final answer is " + finalanswer.finalAnswer);

            if (finalanswer.finalAnswer == randomNumber)
            {
                Debug.Log("Nice points++");
                randomNumber = Random.Range(16, 41);
                randomNumberText.text = "" + randomNumber;
                square1.GetComponent<ResetButton>().resetSquare1();
                square2.GetComponent<ResetButton>().resetSquare2();
                square3.GetComponent<ResetButton>().resetSquare3();
                square4.GetComponent<ResetButton>().resetSquare4();
                square5.GetComponent<ResetButton>().resetSquare5();
                square6.GetComponent<ResetButton>().resetSquare6();
                square7.GetComponent<ResetButton>().resetSquare7();

                StartCoroutine(CorrectText());
                currentScore++;
                if (currentScore == 10)
                {
                    StartCoroutine(WaitForSeconds());
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
        correctMarker.SetActive(true);
        correctText.SetActive(true);
        checkButton.GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(3);
        checkButton.GetComponent<Button>().interactable = true;
        correctText.SetActive(false);
        correctMarker.SetActive(false);
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

    IEnumerator WaitForSeconds()
    {
        goodJob.SetActive(true);
        yield return new WaitForSeconds(4);
        goodJob.SetActive(false);
        SceneManager.LoadScene("LevelSelect");
    }
}
