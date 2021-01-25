using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    float myFloat;
    int myInt;
    string myString;
    bool myBool;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<HingeJoint>().massScale = myFloat;
        GetComponent<SpriteRenderer>().sortingOrder = myInt;
        gameObject.name = myString;
        GetComponent<AudioSource>().loop = myBool;
    }
}
