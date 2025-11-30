using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Economy : MonoBehaviour
{
    public static Economy Instance; // Сінглтон

    [Header("Лічильник")]
    public float clickCounter = 0f; // Лічильник
    public string creditsText; // Текст всередині лічильника

    [Header("Бонус")]
    public float bonusPrice = 100f; // Постійна ціна
    public float bounsPriceMod = 100f; // Модифікатор ціни у %
    public float creditsPerClick = 1f; // Кількість валюти за клік
    [HideInInspector] public float bonusCounter = 0f; // Кількість куплених бонусів

    [Header("АвтоКлік")]
    public float autoClickPrice = 200f;
    public float autoClickPriceMod = 200f;
    public float creditsPerAutoClick = 0f;

    [Header("Тексти на сцені")]
    public TextMeshProUGUI counterTextInGame; // Текст на сцені
    public TextMeshProUGUI counterTextInShop; // Текст в магазині
    public TextMeshProUGUI bonusPriceText;
    public TextMeshProUGUI bonusCounterText;
    private void Awake()
    {
        Instance = this;
    }
    public void TakeCurrentPrice()
    {
        float price = bonusPrice + (bonusPrice / 100 * bounsPriceMod);
        bonusPrice = price;
    }
    public void UpdateText()
    {
        counterTextInGame.text = creditsText + clickCounter.ToString(); // Текст лічильника на сцені
        counterTextInShop.text = creditsText + clickCounter.ToString();
        bonusPriceText.text = $"Ціна: {bonusPrice}";
        bonusCounterText.text = $"+ {creditsPerClick} за клік"; // за клік
    }
}
