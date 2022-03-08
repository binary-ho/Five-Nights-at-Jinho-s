using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Brightness1 : MonoBehaviour
{

    void Start()
    {
        RenderSettings.ambientLight = new Color(0f, 0f, 0f, 1.0f);
    
    }

    // float brightValue = 5;

    // // Update is called once per frame
    // public void ChangeBrighrness()
    // {
    //     brightValue = GUI.HorizontalSlider(new Rect(Screen.width / 2 - 50, 90, 100, 30), brightValue, 0f, 1.0f);
    //     Screen.brightness = brightValue;
    // }
}
