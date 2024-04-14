using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //to get the Text class
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class LogicScript : MonoBehaviour
{
    public int playeScore;
    public Text scoreText;
    public GameObject gameOverScreen;



   
    public void addScore(int scoreToAdd)
    {
        playeScore += scoreToAdd;
        scoreText.text = playeScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);    

    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
