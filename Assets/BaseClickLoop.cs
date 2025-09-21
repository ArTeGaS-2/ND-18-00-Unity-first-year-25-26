using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class BaseClickLoop : MonoBehaviour
{
    public int clickCounter = 0; // ˳�������
    public TextMeshProUGUI textObj; // ����� �� ����
    private bool buttonPressStatus = false; // �� ��������� ������
    public void ClickButton()
    {
        clickCounter++; // ���� ���� �� ������� ���������
        textObj.text = "������: " + clickCounter.ToString(); // ����� ��������� �� ����
    }
    public void OnMouseDown()
    {
        ClickButton(); // ������ ������ ����
        ClickImpactEffect();
    }
    public void ClickImpactEffect()
    {
        if (!buttonPressStatus) // ���� ������ �� ���������
        {
            transform.position = transform.position + new Vector3(0, -0.3f, 0);
        }
    }
}
