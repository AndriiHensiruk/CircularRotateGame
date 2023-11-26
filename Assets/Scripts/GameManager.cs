using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private  int score ;
    private  int bestScore;
    private  string name;
    private  string userIcon;
   
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
    }

    public void IncrementName(string _name)
    {
       name = _name;    
    }

     public void IncrementIcon(Texture2D texture)
    {
         // Convert the Texture2D to a byte array
        byte[] bytes = texture.EncodeToPNG();

        // Convert the byte array to a string
        string base64 = System.Convert.ToBase64String(bytes);
        
        userIcon = base64;    
    }

     public Texture2D ReturnUserIcon()
    {
        string base64 = userIcon;
        // If the string is empty, return null
        if (string.IsNullOrEmpty(base64))
            return null;

        // Convert the string to a byte array
        byte[] bytes = System.Convert.FromBase64String(base64);

        // Create a new Texture2D and load the byte array into it
        Texture2D texture = new Texture2D(2, 2);
        texture.LoadImage(bytes);

        Debug.Log("Loaded texture width: " + texture.width + ", height: " + texture.height);

        return texture;
    }


    public string ReturnName()
    {
        return name;
    }

    public void IncrementBestScore()
    {
        if (bestScore < score)
            bestScore = score;
    }

  
}
