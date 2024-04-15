using System.Collections;
using TMPro;
using System.Collections.Generic;
using UnityEngine;

public class FinishSkript : MonoBehaviour
{
    [SerializeField] GameObject ScreenWicktor;
    [SerializeField] TMP_Text textWictor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(other.gameObject.GetComponent<Ball>().Key)
            {
                other.gameObject.SetActive(false);
                ScreenWicktor.SetActive(true);
                textWictor.text = "Wictory!";
            }
        }
    }
}
