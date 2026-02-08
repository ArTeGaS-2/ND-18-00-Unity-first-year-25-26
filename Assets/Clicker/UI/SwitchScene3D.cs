using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class SwitchScene3D : MonoBehaviour
{
    [Header("Об'єкти гри")]
    public GameObject gameFolderObj; // Об'єкти гри на сцені
    public GameObject gameUIFolderObj; // Елементи інтерфейсу гри на сцені

    [Header("Об'єкти магазину")]
    public GameObject shopFolderObj; // Обеєкти магазину на сцені
    public GameObject shopUIFolderObj; // Елементи інтерфейсу магазину на сцені

    [Header("Загальне")]
    public bool ifGameActive = true; // Індикатор стану сцени

    public void OnMouseDown()
    {
        // Міняємо стан сцени гри
        gameFolderObj.SetActive(!gameFolderObj.activeSelf);
        gameUIFolderObj.SetActive(!gameUIFolderObj.activeSelf);

        // Міняємо стан сцени магазину
        shopFolderObj.SetActive(!shopFolderObj.activeSelf);
        shopUIFolderObj.SetActive(!shopUIFolderObj.activeSelf);
    }
}
