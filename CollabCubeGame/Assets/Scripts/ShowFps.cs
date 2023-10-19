using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowFps : MonoBehaviour
{
    public float fps;
    public TMP_Text fpsText;

    private void Update()
    {
        if(PlayerPrefs.GetInt("ShowFPS") == 1)
        {
            fpsText.enabled = true;
            fps = 1.0f / Time.deltaTime;
            fpsText.text = "FPS: " + (int)fps;
        }
        else
        {
            fpsText.enabled = false;
        }
    }
}
