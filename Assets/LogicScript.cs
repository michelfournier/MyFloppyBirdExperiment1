using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playeScore;
    public Text scoreText;

   
    public void addScore()
    {
        playeScore += 1;
        scoreText.text = playeScore.ToString();
    }

}
