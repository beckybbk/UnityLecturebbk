using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Webimage : MonoBehaviour
{
    public RawImage webimage;

    void Start()
    {
        StartCoroutine(GetTexture(webimage));
    }

    IEnumerator GetTexture(RawImage rImage)
    {
        string url = "https://cdn.pixabay.com/photo/2018/04/23/14/38/dog-3344414_960_720.jpg";

        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);

        yield return www.SendWebRequest();

        if(www.result!= UnityWebRequest.Result.Success) 
        { 
            Debug.Log(www.error);
        }

        else
        {
            webimage.texture=((DownloadHandlerTexture)www.downloadHandler).texture;

        }
    }
}
