using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMov : MonoBehaviour
{
    public AudioClip jumpSound;
    public float impulseForce = 5f;

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

        Vector3 impulseDirection = Vector3.up;
        rb.AddForce(impulseDirection * impulseForce, ForceMode.Impulse);

        AudioSource.PlayClipAtPoint(jumpSound, transform.position);
    }
}
