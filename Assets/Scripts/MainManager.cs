using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public Text lastScoreText;
    public Text bestScoreText;
    public Text userNameText;
    public Text nameText;

    public Image userIcon;
    
    // Start is called before the first frame update
    void Start()
    {
        int _score =  GameManager.inst.ReturnScore();
        lastScoreText.text = _score.ToString();

        int _bestScore =  GameManager.inst.ReturnBestScore();
        bestScoreText.text = _bestScore.ToString();
        
        string _name = GameManager.inst.ReturnName();
        nameText.text = _name.ToString();
        

    }

    public void SaveName()
    {
        string _name = userNameText.text;
        GameManager.inst.IncrementName(_name);
    }

  
}
