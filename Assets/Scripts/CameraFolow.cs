using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFolow : MonoBehaviour
{
    [SerializeField] Transform _shepe;
    [SerializeField] float _speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x>_shepe.position.x || transform.position.y > _shepe.position.y)
            transform.position = new Vector3(transform.position.x-_speed, transform.position.y - _speed, transform.position.z);

        transform.LookAt(_shepe.position);
    }
}
