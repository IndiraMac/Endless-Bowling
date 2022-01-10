using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject creditMenu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            creditMenu.SetActive(false);
            mainMenu.SetActive(true);
        }
    }

    public void Credit()
    {
        mainMenu.SetActive(false);
        creditMenu.SetActive(true);
    }
}
