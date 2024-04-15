using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool Key = false;

    [Range(1f, 5f)]
    public float speed;

    public float ipulseForce = 1f;

    Rigidbody player;

    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.W))
        {
            player.AddForce(new Vector3(0, 0, -1) * ipulseForce, ForceMode.Impulse);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            player.AddForce(new Vector3(0, 0, 1) * ipulseForce, ForceMode.Impulse);
        }

        float horizontal = Input.GetAxis("Horizontal")*-1;

        player.velocity = new Vector3(horizontal * speed, player.velocity.y, player.velocity.z);
    }


}
