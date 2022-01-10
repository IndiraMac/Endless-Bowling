using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeGame : MonoBehaviour
{
    public GameObject exitCanvas;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            exitCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void Yes()
    {
        Application.Quit();
    }

    public void No()
    {
        exitCanvas.SetActive(false);
        Time.timeScale = 1f;
    }
}
