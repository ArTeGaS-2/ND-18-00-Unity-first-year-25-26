using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_2D : MonoBehaviour
{
    [Header("�������")]
    public float cameraHeight = 0f; // ������ ������
    public float cameraDistance= -10f; // ³����� �����\������

    [Header("���������")]
    public float cameraRotationX = 0f;
    public float cameraRotationY = 0f;
    public float cameraRotationZ = 0f;

    [Header("����")]
    public bool isHeightChange = false;

    private GameObject player;

    private void Start()
    {
        // ������ ��'��� ������ �� �����
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
