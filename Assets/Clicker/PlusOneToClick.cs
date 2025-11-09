using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusOneToClick : MonoBehaviour
{
    public void BonusPlusButton()
    {
        Economy.Instance.creditsPerClick += 1;
        Economy.Instance.UpdateText();
        Economy.Instance.clickCounter -= Economy.Instance.bonusPrice;
        Economy.Instance.TakeCurrentPrice();
    }
}
