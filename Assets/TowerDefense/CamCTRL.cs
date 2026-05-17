using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCTRL : MonoBehaviour
{
    [Header("Параметри камери")]
    [SerializeField] float cameraSpeed = 10f; // Швидкість руху камери
    [SerializeField] float zoomSpeed = 10f; // Швидкість зуму камери

    [Header("Обмеження руху")]
    [SerializeField] float horizontalBorder = 50f; // Межа руху по горизонталі
    [SerializeField] float verticalBorder = 50f; // Межа руху по вертикалі

    [Header("Обмеження зуму")]
    [SerializeField] float minZoom = 45f; // Мінімальний зум (найближче)
    [SerializeField] float maxZoom = 75f; // Максимальний зум (найдальше)

    private Vector3 initialPosition; // Початкова позиція камери
    private Vector3 positionLimits; // Межі руху камери

    private void Start()
    {
        // Початкова позиція = позиція об'єкта, до якого прикріплений цей скрипт
        initialPosition = transform.position;
        // Встановлення меж руху камери
        positionLimits = new Vector3(
            horizontalBorder,     // Межа руху по горизонталі
            transform.position.y, // Висота камери залишається незмінною
            verticalBorder);      // Межа руху по вертикалі
    }

    private void FixedUpdate()
    {
        CameraMove();
        ZoomCamera();
    }
    private void CameraMove()
    {
        // Введення з клавіатури
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Рух по 4 напрямках
        transform.position = new Vector3(
            transform.position.x + horizontal * cameraSpeed * Time.fixedDeltaTime,
            transform.position.y,
            transform.position.z + vertical * cameraSpeed * Time.fixedDeltaTime);
        // Обмеження руху камери в межах заданих кордонів
        transform.position = new Vector3(
            // Обмеження руху по горизонталі
            Mathf.Clamp(
                transform.position.x,
                initialPosition.x - positionLimits.x,
                initialPosition.x + positionLimits.x),
            // Висота камери залишається незмінною
            transform.position.y,
            // Обмеження руху по вертикалі
            Mathf.Clamp(
                transform.position.z,
                initialPosition.z - positionLimits.z,
                initialPosition.z + positionLimits.z));
    }
    private void ZoomCamera()
    {
        // Скролл колесом миші
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Camera.main.fieldOfView -= scroll * zoomSpeed * Time.fixedDeltaTime;

        Camera.main.fieldOfView = Mathf.Clamp(
            Camera.main.fieldOfView,
            minZoom,
            maxZoom);
    }
}
