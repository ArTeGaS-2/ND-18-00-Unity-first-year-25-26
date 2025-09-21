using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class BaseClickLoop : MonoBehaviour
{
    public int clickCounter = 0; // Лічильник
    public TextMeshProUGUI textObj; // Текст на сцені
    private bool buttonPressStatus = false; // Чи натиснута кнопка
    public void ClickButton()
    {
        clickCounter++; // Плюс один на кожному натисканні
        textObj.text = "Монети: " + clickCounter.ToString(); // Текст лічильника на сцені
    }
    public void OnMouseDown()
    {
        ClickButton(); // Виклик метода кліку
        ClickImpactEffect();
    }
    public void ClickImpactEffect()
    {
        if (!buttonPressStatus) // Якщо кнопка НЕ натиснута
        {
            transform.position = transform.position + new Vector3(0, -0.3f, 0);
        }
    }
}
