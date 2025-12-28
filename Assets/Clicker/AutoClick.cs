using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClick : MonoBehaviour
{
    public static AutoClick Instance; // Сінглтон
    private void Awake()
    {
        Instance = this;
    }
    public IEnumerator AutoClickCicle(float interval, float CPS)
    {
        Economy.Instance.clickCounter += CPS;
        Economy.Instance.UpdateText();
        yield return new WaitForSeconds(interval);
    }
}
