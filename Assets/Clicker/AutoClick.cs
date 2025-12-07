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
    public IEnumerator AutoClickCicle(
        float counter, float interval, float CPS)
    {
        counter += CPS;
        yield return new WaitForSeconds(interval);
    }
}
