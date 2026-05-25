using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [Header("Об'єкти")]
    [SerializeField] GameObject projectile; // Посилання на снаряд
    [SerializeField] GameObject spawnPoint; // точка спавну снаряду

    [Header("Параметри вежі")]
    public float attackInterval = 1f; // Інтервал між пострілами 
    public float attackDamage = 1f; // Шкода від вежі
    public float attackRadius = 5f; // Радіус атаки

    private List<GameObject> enemiesList; // Список ворогів, які знаходяться в радіусі атаки

    private bool enemiInRadius; // Чи є вороги в радіусі атаки
    private Coroutine towerAttack; // Посилання на корутину атаки вежі

    private void Awake()
    {
        enemiesList = new List<GameObject>(); // Ініціалізація списка
    }

    private void Start()
    {
        // StartCoroutine(Shoot());
        towerAttack = null;
    }
    private IEnumerator Shoot()
    {
        while (true) 
        {
            if (enemiesList.Count > 0)
            {
                Projectile projectileScript = Instantiate(
                projectile, // Об'єкт який створюємо
                spawnPoint.transform.position, // Точка виходу снаряду
                Quaternion.identity).GetComponent<Projectile>();

                projectileScript.targetObj = enemiesList[0];
            }
            yield return new WaitForSeconds(attackInterval); // Затримку у сек
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy")) // перевіряємо тег
        {
            if (enemiesList.Count == 0) // якщо ворогів ще немає в радіусі
            {
                towerAttack = StartCoroutine(Shoot()); // починає стріляти
            }
            enemiesList.Add(other.gameObject); // додаємо ворога у список
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy")) // перевіряємо тег
        {
            if (enemiesList.Count == 0) // якщо ворогів ще немає в радіусі
            {
                StopCoroutine(towerAttack);
            }
            enemiesList.Remove(other.gameObject);
        }
    }
}
