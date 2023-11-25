using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private  int score = 0;
    
    public Text scoreText;

     public static GameController inst;
    
    private void Awake()
    {
        inst = this;
    }
    public void IncrementScore()
    {
        score++;
        //FindObjectOfType<AudioManager>().PlaySound("Ball");
        scoreText.text = score.ToString();

    }
    public void DeleteScore()
    {
        int i = 5;
        score = score -i;
        scoreText.text = score.ToString();

    }
}
