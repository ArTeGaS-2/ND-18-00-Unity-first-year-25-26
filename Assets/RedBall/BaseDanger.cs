using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseDanger : MonoBehaviour
{
    public string sceneToLoad = "RedBall"; // Назва сцени
    public string playerTag = "Player"; // Тег гравця
    private void OnCollisionEnter(Collision collision)
    {
        // Перевіряємо, чи зіткнення відбулося з гравцем
        if (collision.gameObject.CompareTag(playerTag))
        {
            // Завантажуємо вказану сцену
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
