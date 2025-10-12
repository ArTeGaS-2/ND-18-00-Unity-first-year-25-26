using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class BaseClickLoop : MonoBehaviour
{
    public int clickCounter = 0; // Лічильник
    public TextMeshProUGUI textObj; // Текст на сцені
    public TextMeshProUGUI shopTextObj; // Текст на сцені в магазині

    public string creditsText; // Текст всередині лічильника

    [HideInInspector]public int creditsPerClick = 1; // Кількість валюти за клік

    private bool buttonPressStatus = false; // Чи натиснута кнопка
    public void ClickButton()
    {
        clickCounter += creditsPerClick; // Додає кредити за клік
        textObj.text = creditsText + clickCounter.ToString(); // Текст лічильника на сцені
        shopTextObj.text = creditsText + clickCounter.ToString();
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
