using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMov : MonoBehaviour
{
    public float impulseForce = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Получаем компонент Rigidbody объекта, который столкнулся с платформой
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

        Vector3 impulseDirection = Vector3.up;
        rb.AddForce(impulseDirection * impulseForce, ForceMode.Impulse); 


    }
}
