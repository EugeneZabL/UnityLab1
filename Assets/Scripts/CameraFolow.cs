using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFolow : MonoBehaviour
{
    [SerializeField] GameObject _shepe;
    [SerializeField] float _speed;

    void Start()
    {

    }

    void FixedUpdate()
    {
        if (transform.position.x > _shepe.transform.position.x || transform.position.y > _shepe.transform.position.y && _shepe.activeInHierarchy)
            transform.position = new Vector3(transform.position.x - _speed, transform.position.y - _speed, transform.position.z);


        transform.LookAt(_shepe.transform.position);
    }
}
