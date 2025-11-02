using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Economy : MonoBehaviour
{
    public static Economy Instance; // Сінглтон

    public int clickCounter = 0; // Лічильник
    public TextMeshProUGUI textObj; // Текст на сцені
    public TextMeshProUGUI shopTextObj; // Текст на сцені в магазині

    public string creditsText; // Текст всередині лічильника

    [HideInInspector] public int creditsPerClick = 1; // Кількість валюти за клік

    private void Awake()
    {
        Instance = this;
    }
    public float TakeCurrentPrice()
    {

    }
    public void UpdateText()
    {
        textObj.text = creditsText + clickCounter.ToString(); // Текст лічильника на сцені
        shopTextObj.text = creditsText + clickCounter.ToString();
    }
}
