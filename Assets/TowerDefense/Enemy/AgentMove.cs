using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentMove : MonoBehaviour
{
    [Header("Агент")]
    // Агент, який буде рухатися до цілі
    [SerializeField] NavMeshAgent agent;
    // Максимальна кількість очок здоров'я агента
    [SerializeField] float maxHitPoints = 20f;
    // Мінімальна кількість здоров'я
    [SerializeField] float minHitPoints = 0f;

    [Header("Інше")]
    // Ім'я об'єкта, який буде ціллю для агента
    [SerializeField] string targetName = "TargetPoint";

    private void Awake()
    {
        // Отримуємо компонент "агент" з ворога
        agent = GetComponent<NavMeshAgent>();

        agent.SetDestination(           // Встановлення цілі об'єкту
            GameObject.Find(targetName  // Пошук на сцені за іменем
            ).transform.position);      // Позиція цілі
    }
}
