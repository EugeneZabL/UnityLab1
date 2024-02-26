using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilitiesExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //You can access a static method by using the class name
        //and the dot operator.
        int x = Utilities.Add(5, 6);
        Debug.Log(x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public static class Utilities
{
    //A static method can be invoked without an object
    //of a class. Note that static methods cannot access
    //non-static member variables.
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}