using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBall : MonoBehaviour
{
    [SerializeField] AudioClip ForJump;
    [SerializeField] AudioClip ForDie;
    [SerializeField] GameObject DeadScene;
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
        AudioSource.PlayClipAtPoint(ForJump, transform.position);
    }

    private void OnDisable()
    {
        AudioSource.PlayClipAtPoint(ForDie, transform.position);
        DeadScene.SetActive(true);
    }
}
