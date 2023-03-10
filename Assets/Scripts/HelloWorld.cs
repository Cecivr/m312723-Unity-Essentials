using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    [SerializeField] string myMessage;
    void Start()
    {

    }
    void Update()
    {
        Debug.Log(myMessage);        
    }
}
