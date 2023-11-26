using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.Networking;

public class ProfilePicManager : MonoBehaviour
{
    public Image userIcon;

    
    public void LoadFromFile()
    {
        //NativeGallery.Permission per = NativeGallery.RequestPermission();
 
        // probably should do some permissions checking here
 
        NativeGallery.Permission permission = NativeGallery.GetImageFromGallery((path) =>
        {
            if (path != null)
            {
                // Create Texture from selected image
 
                Texture2D texture = NativeGallery.LoadImageAtPath(path, 2073600, false);
 
                if (texture == null) return;
 
                StartCoroutine(UploadImage(texture));

                Sprite sprite = Sprite.Create( texture, new Rect( 0f, 0f, texture.width, texture.height ), new Vector2( 0.5f, 0.5f ), 100f );
                userIcon.sprite = sprite;
            }

        }, "Select an image", "image/*");
    }
 
    IEnumerator UploadImage(Texture2D theimage)
    {
        var form = new WWWForm();
        form.AddBinaryData("imagedata", theimage.EncodeToPNG(), "uploadedimage");
 
        UnityWebRequestAsyncOperation www = UnityWebRequest.Post("https://www.myrandomserver.com/uploadimage.php", form).SendWebRequest();
 
        yield return www;
 
        if (www.webRequest.isHttpError || www.webRequest.isNetworkError)
        {
            Debug.Log("Error: " + www.webRequest.error);
        }
        else
        {
            Debug.Log("Done!");
        }
    }     

}
