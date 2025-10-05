using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    [Header("��'���� ���")]
    public GameObject gameFolderObj; // ��'���� ��� �� ����
    public GameObject gameUIFolderObj; // �������� ���������� ��� �� ����

    [Header("��'���� ��������")]
    public GameObject shopFolderObj; // ������ �������� �� ����
    public GameObject shopUIFolderObj; // �������� ���������� �������� �� ����

    [Header("��������")]
    public bool ifGameActive = true; // ��������� ����� �����

    public void Switch_Game_Shop_Button()
    {
        // ̳����� ���� ����� ���
        gameFolderObj.SetActive(!gameFolderObj.activeSelf);
        gameUIFolderObj.SetActive(!gameUIFolderObj.activeSelf);

        // ̳����� ���� ����� ��������
        shopFolderObj.SetActive(!shopFolderObj.activeSelf);
        shopUIFolderObj.SetActive(!shopUIFolderObj.activeSelf);
    }
}
