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
    public float autoClickPrice = 200f; // Ціна
    public float autoClickPriceMod = 200f; // модифікатор ціни
    public float creditsPerAutoClick = 0f; // кількість за секунду
    public float interval = 1f; // затримка у секунду
    private Coroutine autoClickRoutine; // процес автокліку

    [Header("Тексти на сцені")]
    public TextMeshProUGUI counterTextInGame; // Текст на сцені
    public TextMeshProUGUI counterTextInShop; // Текст в магазині
    public TextMeshProUGUI bonusPriceText; // Ціна бонусу кліку
    public TextMeshProUGUI bonusCounterText; // Кількість куплених бонусів
    public TextMeshProUGUI autoBonusPriceText; // Ціна авто кліку
    public TextMeshProUGUI autoBonusCounterText; // Кількість куплених автокліків

    private void Awake()
    {
        Instance = this;
    }
    public void TakeCurrentPrice()
    {
        float price = bonusPrice + (bonusPrice / 100 * bounsPriceMod);
        bonusPrice = price;
    }
    public void UpdateAutoClick()
    {
        if (clickCounter >= autoClickPrice)
        {
            if(autoClickRoutine != null)
            {
                StopCoroutine(autoClickRoutine);
            }
            clickCounter -= autoClickPrice;

            float price = autoClickPrice +
                (autoClickPrice / 100 * autoClickPriceMod);
            autoClickPrice = price;

            creditsPerAutoClick += 1;
            autoClickRoutine = StartCoroutine(
                AutoClick.Instance.AutoClickCicle(
                    interval, creditsPerAutoClick));

        }
    }
    public void UpdateText()
    {
        counterTextInGame.text = creditsText + clickCounter.ToString(); // Текст лічильника на сцені
        counterTextInShop.text = creditsText + clickCounter.ToString();
        bonusPriceText.text = $"Ціна: {bonusPrice}";
        bonusCounterText.text = $"+ {creditsPerClick} за клік"; // за клік
    }
}
