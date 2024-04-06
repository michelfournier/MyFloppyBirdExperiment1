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

    public PipeSpwaning stopTheSpawning;

    //public GameObject stopThePipes;


    
    public void Start()
    {
        stopTheSpawning = GameObject.FindGameObjectWithTag("spawner").GetComponent<PipeSpwaning>();
        //stopThePipes = GameObject.FindGameObjectWithTag("pipe");
        //Debug.Log(stopThePipes);
    }


   
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
        stopTheSpawning.birdIsDead = true;
        //stopThePipes.birdIsDead = true;       

    }

}
