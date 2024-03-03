using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] AudioClip ForJump;
    [SerializeField] AudioClip ForDie;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        AudioSource.PlayClipAtPoint(ForJump,transform.position);
    }

    private void OnDisable()
    {
        AudioSource.PlayClipAtPoint(ForDie, transform.position);
    }

}
