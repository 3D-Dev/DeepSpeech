using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PluginWrapper : MonoBehaviour
{
    public Text myText;
    public Text LogText;
    private AndroidJavaObject javaClass;

    void Start()
    {
        javaClass = new AndroidJavaObject("com.mozilla.deepspeech.libdeepspeech.API");
    }
    public void StartButton()
    {
        javaClass.Call("start");
    }
    public void EndButton()
    {
        javaClass.Call("stop");
    }
    public void GetTextButton()
    {
        myText.text = javaClass.Call<string>("getText");
        /*
        try
        {
            if (javaClass != null)
            {
                myText.text = javaClass.Call<string>("getText");
            }
            else
            {
                LogText.text = "null";
            }
        }
        catch (Exception ex)
        {
            LogText.text = ex.ToString();
        }
        */
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
