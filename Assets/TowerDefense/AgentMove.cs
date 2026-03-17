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

    [Header("Інше")]
    // Ім'я об'єкта, який буде ціллю для агента
    [SerializeField] string targetName = "TargetPoint";

}
