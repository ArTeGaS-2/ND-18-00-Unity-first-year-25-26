using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCTRL : MonoBehaviour
{
    [Header("Параметри камери")]
    [SerializeField] float cameraSpeed = 10f;
    [SerializeField] float cameraDistance = 30f;

    [Header("Обмеження")]
    [SerializeField] float horizontalBorder = 50f;
    [SerializeField] float verticalBorder = 50f;

    private void FixedUpdate()
    {
        // Введення з клавіатури
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Скролл колесом миші
        float scroll = Input.GetAxis("Mouse ScrollWheel");

        // Рух по 4 напрямках
        transform.position = new Vector3(
            transform.position.x + horizontal * cameraSpeed * Time.fixedDeltaTime,
            transform.position.y,
            transform.position.z + vertical * cameraSpeed * Time.fixedDeltaTime);

        Camera.main.fieldOfView -= scroll * cameraDistance * Time.fixedDeltaTime;
    }
}
