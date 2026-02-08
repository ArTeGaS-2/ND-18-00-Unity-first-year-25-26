using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusOneToClick : MonoBehaviour
{
    public void BonusPlusButton()
    {
        if (Economy.Instance.clickCounter >= Economy.Instance.bonusPrice)
        {
            Economy.Instance.creditsPerClick += 1;
            Economy.Instance.clickCounter -= Economy.Instance.bonusPrice;
            Economy.Instance.TakeCurrentPrice();
            Economy.Instance.UpdateText();
        }
    }
}
