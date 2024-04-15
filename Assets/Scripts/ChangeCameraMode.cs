using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraMode : MonoBehaviour
{
    [SerializeField] private GameObject Camera1;
    [SerializeField] private GameObject ParticleSystems;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Debug.Log("PALYER");
            Camera1.GetComponent<CameraFolow>().enabled = false;
            Camera1.GetComponent<CameraPlayeble>().enabled = true;
            collision.gameObject.GetComponent<Ball>().enabled = true;
            ParticleSystems.SetActive(true);
        }
    }
}
