using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class BaseClickLoop : MonoBehaviour
{
    private bool buttonPressStatus = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ClickButton();
            ClickImpactEffect();
        }
    }
    public void ClickButton()
    {
        Economy.Instance.clickCounter +=
            Economy.Instance.creditsPerClick; // Додає кредити за клік
        Economy.Instance.UpdateText();
    }
    public void OnMouseDown()
    {
        ClickButton(); // Виклик метода кліку
        ClickImpactEffect();
    }
    public void OnMouseUp()
    {
        DisableClickImpacktEffect();
    }
    public void ClickImpactEffect()
    {
        if (buttonPressStatus == false) // Якщо кнопка НЕ натиснута
        {
            transform.localPosition = new Vector3(0, 0.25f, 0);
            buttonPressStatus = true;
        }
    }
    public void DisableClickImpacktEffect()
    {
        if (buttonPressStatus == true) // Якщо кнопка натиснута
        {
            transform.localPosition = new Vector3(0, 0.44f, 0);
            buttonPressStatus = false;
        }
    }
}
