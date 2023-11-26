using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameManager : MonoBehaviour
{
    public Text userNameText;
    public Text lastScoreText;
    public Text bestScoreText;
    public Image userIcon;
    // Start is called before the first frame update
    void Start()
    {
        int _score =  GameManager.inst.ReturnScore();
        lastScoreText.text = _score.ToString();

        int _bestScore =  GameManager.inst.ReturnBestScore();
        bestScoreText.text = _bestScore.ToString();
        
        string _name = GameManager.inst.ReturnName();
        userNameText.text = _name.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
