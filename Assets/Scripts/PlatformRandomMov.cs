using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRandomMov : MonoBehaviour
{
    private Vector3 initialPosition;
    private float moveRange = 20f;
    private Vector3 velocity = Vector3.zero; // початкова швидкість згладжування

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        // Генеруємо випадковий зсув для координат X та Z
        float randomX = Random.Range(-moveRange, moveRange);
        float randomZ = Random.Range(-moveRange, moveRange);

        // Створюємо нову позицію платформи з урахуванням випадкового зсуву
        Vector3 targetPosition = new Vector3(initialPosition.x + randomX, initialPosition.y, initialPosition.z + randomZ);

        // Плавно переміщуємо платформу до нової позиції
        float smoothTime = 0.3f; // час згладжування
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
