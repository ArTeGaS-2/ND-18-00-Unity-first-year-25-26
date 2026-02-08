using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_2D : MonoBehaviour
{
    [Header("Позиція")]
    public float cameraHeight = 0f; // Висота камери
    public float cameraDistance= -10f; // Відступ назад\вперед

    [Header("Обертання")]
    public float cameraRotationX = 0f;
    public float cameraRotationY = 0f;
    public float cameraRotationZ = 0f;

    [Header("Інше")]
    public bool isHeightChange = false;

    private GameObject player;

    private void Start()
    {
        // Шукаємо об'єкт гравця за тегом
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void LateUpdate()
    {
        TrackPlayerByCamera();
    }
    private void TrackPlayerByCamera()
    {
        transform.position = new Vector3(
            player.transform.position.x,
            isHeightChange ? player.transform.position.y + cameraHeight : cameraHeight,
            player.transform.position.z + cameraDistance);
    }
}
