using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class SwitchScene3D : MonoBehaviour
{
    [Header("��'���� ���")]
    public GameObject gameFolderObj; // ��'���� ��� �� ����
    public GameObject gameUIFolderObj; // �������� ���������� ��� �� ����

    [Header("��'���� ��������")]
    public GameObject shopFolderObj; // ������ �������� �� ����
    public GameObject shopUIFolderObj; // �������� ���������� �������� �� ����

    [Header("��������")]
    public bool ifGameActive = true; // ��������� ����� �����

    public void OnMouseDown()
    {
        // ̳����� ���� ����� ���
        gameFolderObj.SetActive(!gameFolderObj.activeSelf);
        gameUIFolderObj.SetActive(!gameUIFolderObj.activeSelf);

        // ̳����� ���� ����� ��������
        shopFolderObj.SetActive(!shopFolderObj.activeSelf);
        shopUIFolderObj.SetActive(!shopUIFolderObj.activeSelf);
    }
}
