using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRandomMov : MonoBehaviour
{
    private Vector3 initialPosition;
    private float moveRange = 20f;
    private Vector3 velocity = Vector3.zero; // ��������� �������� ������������

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        // �������� ���������� ���� ��� ��������� X �� Z
        float randomX = Random.Range(-moveRange, moveRange);
        float randomZ = Random.Range(-moveRange, moveRange);

        // ��������� ���� ������� ��������� � ����������� ����������� �����
        Vector3 targetPosition = new Vector3(initialPosition.x + randomX, initialPosition.y, initialPosition.z + randomZ);

        // ������ ��������� ��������� �� ���� �������
        float smoothTime = 0.3f; // ��� ������������
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
