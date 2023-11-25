using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProfilePicManager : MonoBehaviour
{
    public Image userIcon;

    // Start is called before the first frame update
    

    public void LoadScane(int _sceneId)
    {
        SceneManager.LoadSceneAsync(_sceneId);
    } 
}
