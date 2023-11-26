using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScane : MonoBehaviour
{
    public void ScaneLoad(int _sceneId)
    {
        SceneManager.LoadSceneAsync(_sceneId);
    } 

}
