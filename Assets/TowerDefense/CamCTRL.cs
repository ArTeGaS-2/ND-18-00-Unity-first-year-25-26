using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCTRL : MonoBehaviour
{
    [Header("Параметри камери")]
    [SerializeField] float cameraSpeed = 1f;
    [SerializeField] float cameraDistance = 10f;

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

        // Рух вперед/назад та вліво/вправо
        transform.position = new Vector3(
            transform.position.x + horizontal * cameraSpeed * Time.deltaTime,
            transform.position.y,
            transform.position.z + vertical * cameraSpeed * Time.deltaTime);

        Camera.main.fieldOfView += scroll * cameraSpeed * Time.deltaTime;
    }
}
