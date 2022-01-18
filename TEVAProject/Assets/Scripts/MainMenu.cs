using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("LevelSelect");
    }   

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting the game!");
    }

    public void LevelSelect1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LevelSelect2()
    {
        SceneManager.LoadScene("Level2");
    }  
    
    public void LevelSelect3()
    {
        SceneManager.LoadScene("Level3");
    }
}
