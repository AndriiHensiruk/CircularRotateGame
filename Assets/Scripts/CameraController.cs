using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    private WebCamTexture webCam;
    private Texture defaultBackground;

    public RawImage background;
    

   
    public void OpenCamera()
    {
        defaultBackground = background.texture;
        WebCamDevice[] devices = WebCamTexture.devices;
        if (devices.Length == 0)
        {
            Debug.Log("No camera detected");
            //camAvailable = false;
            return;
        }

        for (int i = 0; i < devices.Length; i++)
        {
            if (devices[i].isFrontFacing)
            {
                webCam = new WebCamTexture(devices[i].name, Screen.width, Screen.height);
            }
        }

        if (webCam == null)
        {
            Debug.Log("Unable to find back Camera");
            return;
        }

        webCam.Play();
        background.texture = webCam;
    }

     public void callTakePhoto() // call this function in button click event
    {
        StartCoroutine(TakePhoto());
    }

    IEnumerator TakePhoto()  // Start this Coroutine on some button click
    {

        

        yield return new WaitForEndOfFrame();


        Texture2D photo = new Texture2D(webCam.width, webCam.height);
        photo.SetPixels(webCam.GetPixels());
        photo.Apply();

        //Encode to a PNG
        byte[] bytes = photo.EncodeToPNG();
        //Write out the PNG. Of course you have to substitute your_path for something sensible
        File.WriteAllBytes("\\photo.png", bytes);

    }

}