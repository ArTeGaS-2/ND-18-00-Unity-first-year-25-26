using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class BaseClickLoop : MonoBehaviour
{
    private float clickCounter; // Лічильник
    private TextMeshProUGUI textObj; // Текст на сцені
    private TextMeshProUGUI shopTextObj; // Текст на сцені в магазині

    private string creditsText; // Текст всередині лічильника

    private float creditsPerClick; // Кількість валюти за клік

    private bool buttonPressStatus = false; // Чи натиснута кнопка
    private void Start()
    {
        clickCounter = Economy.Instance.clickCounter;
        textObj = Economy.Instance.textObj;
        shopTextObj = Economy.Instance.shopTextObj;
        creditsText = Economy.Instance.creditsText;
        creditsPerClick = Economy.Instance.creditsPerClick;
    }
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
