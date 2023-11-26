using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private  int score ;
    private  int bestScore;
    private  string name;
    
   
    public static GameManager inst;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        inst = this;
    }

    public int ReturnScore()
    {
        return score;
    }

    public int ReturnBestScore()
    {
        return score;
    }

    public void IncrementScore()
    {
        score++;   
        Debug.Log("POINT");
    }

    public void IncrementBestScore()
    {
        if (bestScore < score)
            bestScore = score;
    }

  
}
