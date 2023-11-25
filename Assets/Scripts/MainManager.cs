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
    public Image userIcon;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    public void LoadScane(int _sceneId)
    {
        SceneManager.LoadSceneAsync(_sceneId);
    } 

  
}
