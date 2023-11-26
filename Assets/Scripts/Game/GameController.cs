using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text scoreText;
    
    public static GameController inst;

    private void Awake()
    {
        inst = this;
    }

    public void ShowScore()
    {
        int score =  GameManager.inst.ReturnScore();
        scoreText.text = score.ToString();
    }

    public void LoadEndGame()
    {
        SceneManager.LoadSceneAsync(5);
    }
    
    
    
}
