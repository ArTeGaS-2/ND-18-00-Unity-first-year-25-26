using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject targetObj; // Посилання на ціль на сцені
    [SerializeField] float projectileSpeed = 1.0f; // швидкість

    private void FixedUpdate()
    {
        // Рух до цілі
        transform.position = Vector3.MoveTowards(
            transform.position, // Вихідні координати
            targetObj.transform.position, // цільова позиція
            projectileSpeed * Time.fixedDeltaTime); // швидкість

        transform.LookAt(targetObj.transform); // обертання
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") ||
            collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
