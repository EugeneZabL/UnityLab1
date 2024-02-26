using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello_World : MonoBehaviour
{
    public string message;
    public Vector3 positionChange;
    public Vector3 rotateChange;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Buenos d?as");
        Debug.Log(message);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Soy simplemente un cubo");
        transform.position += positionChange;
        transform.Rotate(rotateChange);
    }
}
