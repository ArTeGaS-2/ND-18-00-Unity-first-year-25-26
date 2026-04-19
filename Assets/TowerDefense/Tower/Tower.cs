using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] GameObject projectile; // Посилання на снаряд
    [SerializeField] GameObject spawnPoint; // точка спавну снаряду
    public float attackInterval = 1f; // Інтервал між пострілами 
    
    private void Start()
    {
        StartCoroutine(Shoot());
    }
    private IEnumerator Shoot()
    {
        while (true) 
        {
            yield return new WaitForSeconds(attackInterval); // Затримку у сек
            Instantiate(
                projectile, // Об'єкт який створюємо
                spawnPoint.transform.position, // Точка виходу снаряду
                Quaternion.identity); // Обертання
        }
    }
}
