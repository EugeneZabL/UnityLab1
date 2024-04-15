using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject OFF;
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Ball>().Key = true;
        OFF.gameObject.SetActive(false);
    }
}
