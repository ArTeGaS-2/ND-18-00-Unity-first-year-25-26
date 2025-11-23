using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public GameObject escMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            escMenu.SetActive(!escMenu.activeSelf);
        }
    }
    public void EscButtonPress()
    {
        Application.Quit();
    }
    public void ReturnButtonPress()
    {
        escMenu.SetActive(!escMenu.activeSelf);
    }
}
