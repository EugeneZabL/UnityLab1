using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    [SerializeField] float _speedLava;
    int stage = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >=  0.3)
            stage = -1;
        else if (transform.position.x <= - 0.3)
            stage = 1;
        transform.position = new Vector3(transform.position.x + (_speedLava*stage), transform.position.y + (_speedLava * stage), transform.position.z + (_speedLava * stage));

    }

    private void OnTriggerEnter(Collider other)
    {
         Destroy(other.gameObject);
    }
}
