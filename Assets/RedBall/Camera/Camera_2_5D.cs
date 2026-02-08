using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_2_5D : MonoBehaviour
{
    [Header("Змішане 2.5D позиція")]
    public float camera_2D_HeightMixed = 0f; // Висота камери
    public float camera_2D_DistanceMixed = -10f; // Відступ назад\вперед
    // 3D
    public float camera_3D_HeightMixed = 3f; // Висота камери
    public float camera_3D_DistanceMixed = -5f; // Відступ назад\вперед

    [Header("Змішане 2.5D обертання")]
    public float camera_2D_VerticalAngle = 0f; // Нахил по вертикалі
    public float camera_2D_HorizontalAngle = -90f; // Нахил по горизонту
    // 3D
    public float camera_3D_VerticalAngle = 20f; // Нахил по вертикалі
    public float camera_3D_HorizontalAngle = 0f; // Нахил по горизонту
}
