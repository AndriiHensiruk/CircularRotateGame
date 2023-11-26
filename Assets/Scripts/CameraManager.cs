using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System.Collections.Generic;

public class CameraManager : MonoBehaviour
{
    public GameObject takeFoto;

   public void ShawCamera()
   {
        takeFoto.SetActive(true);
   }
}