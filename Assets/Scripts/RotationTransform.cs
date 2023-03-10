using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTransform : MonoBehaviour
{
    public Vector3 rotationTransform;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(rotationTransform);
    }
}
