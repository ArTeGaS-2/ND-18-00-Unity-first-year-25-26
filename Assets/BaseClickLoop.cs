using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class BaseClickLoop : MonoBehaviour
{
    public int clickCounter = 0; // ˳�������
    public TextMeshProUGUI textObj; // ����� �� ����
    public TextMeshProUGUI shopTextObj; // ����� �� ���� � �������

    public string creditsText; // ����� �������� ���������

    [HideInInspector]public int creditsPerClick = 1; // ʳ������ ������ �� ���

    private bool buttonPressStatus = false; // �� ��������� ������
    public void ClickButton()
    {
        clickCounter += creditsPerClick; // ���� ������� �� ���
        textObj.text = creditsText + clickCounter.ToString(); // ����� ��������� �� ����
        shopTextObj.text = creditsText + clickCounter.ToString();
    }
    public void OnMouseDown()
    {
        ClickButton(); // ������ ������ ����
        ClickImpactEffect();
    }
    public void OnMouseUp()
    {
        DisableClickImpacktEffect();
    }
    public void ClickImpactEffect()
    {
        if (buttonPressStatus == false) // ���� ������ �� ���������
        {
            transform.localPosition = new Vector3(0, 0.25f, 0);
            buttonPressStatus = true;
        }
    }
    public void DisableClickImpacktEffect()
    {
        if (buttonPressStatus == true) // ���� ������ ���������
        {
            transform.localPosition = new Vector3(0, 0.44f, 0);
            buttonPressStatus = false;
        }
    }
}
