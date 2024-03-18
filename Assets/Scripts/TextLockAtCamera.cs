using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextLockAtCamera : MonoBehaviour
{
    [SerializeField] private Transform _Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.LookAt(_Camera);
    }
}
