using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClick : MonoBehaviour
{
    public float interval = 1f;
    private void Update()
    {
        Economy.Instance.clickCounter += interval;
    }
}
