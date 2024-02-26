using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerT : MonoBehaviour
{
    //Static variables are shared across all instances
    //of a class. 
    public static int playerCount = 0;

    void Start()
    {
        //Increment the static variable to know how many
        //objects of this class have been created.
        playerCount++;
        Debug.Log(playerCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
